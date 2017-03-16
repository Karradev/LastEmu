using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Protocol
{
    public static class ReflectionExtensions
    {
        public static T CreateDelegate<T>(this ConstructorInfo ctor)
        {
            var list = ctor.GetParameters().Select(param => Expression.Parameter(param.ParameterType)).ToList();
            var expression = Expression.Lambda<T>(Expression.New(ctor, list), list);
            return expression.Compile();
        }

        private static bool FilterByName(Type typeObj, object criteriaObj)
        {
            return typeObj.ToString() == criteriaObj.ToString();
        }

        public static Type GetActionType(this MethodInfo method)
        {
            Type actionType = Expression.GetActionType((
                from entry in (IEnumerable<ParameterInfo>)method.GetParameters()
                select entry.ParameterType).ToArray<Type>());
            return actionType;
        }

        public static T GetCustomAttribute<T>(this ICustomAttributeProvider type)
        where T : Attribute
        {
            return type.GetCustomAttributes<T>().FirstOrDefault<T>();
        }

        public static T[] GetCustomAttributes<T>(this ICustomAttributeProvider type)
        where T : Attribute
        {
            return type.GetCustomAttributes(typeof(T), false) as T[];
        }

        public static bool HasInterface(this Type type, Type interfaceType)
        {
            bool length = type.FindInterfaces(new TypeFilter(ReflectionExtensions.FilterByName), interfaceType).Length != 0;
            return length;
        }

        public static bool IsDerivedFromGenericType(this Type type, Type genericType)
        {
            bool flag;
            if (type == typeof(object))
            {
                flag = false;
            }
            else if (type != null)
            {
                flag = ((type.IsGenericType && type.GetGenericTypeDefinition() == genericType) || type.BaseType.IsDerivedFromGenericType(genericType));
            }
            else
            {
                flag = false;
            }
            return flag;
        }
    }
}