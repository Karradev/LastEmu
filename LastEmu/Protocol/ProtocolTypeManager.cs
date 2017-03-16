using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace Protocol
{
	public static class ProtocolTypeManager
	{
		private static readonly Dictionary<ushort, Type> Types;

		private static readonly Dictionary<ushort, Func<object>> TypesConstructors;

		static ProtocolTypeManager()
		{
			Types = new Dictionary<ushort, Type>(200);
			TypesConstructors = new Dictionary<ushort, Func<object>>(200);
			var types = Assembly.GetAssembly(typeof(ProtocolTypeManager)).GetTypes();
			foreach (var type in types)
			{
			    if (!(type.Namespace?.StartsWith(typeof (ProtocolTypeManager).Namespace) ?? false)) continue;
			    var field = type.GetField("Id");
			    if (field == null) continue;
			    var num = Convert.ToUInt16(field.GetValue(type));
			    ProtocolTypeManager.Types.Add(num, type);
			    var constructor = type.GetConstructor(Type.EmptyTypes);
			    if (constructor == null)
			    {
			        throw new Exception($"'{type}' doesn't implemented a parameterless constructor");
			    }
			    TypesConstructors.Add(num, constructor.CreateDelegate<Func<object>>());
			}
		}

		public static T GetInstance<T>(short id)
		where T : class
		{
			if (!Types.ContainsKey((ushort)id))
			{
				throw new ProtocolTypeNotFoundException($"Type <id:{id}> doesn't exist");
			}
			return TypesConstructors[(ushort)id]() as T;
		}

		public static T GetInstance<T>(ushort id)
		where T : class
		{
			if (!Types.ContainsKey(id))
			{
				throw new ProtocolTypeNotFoundException($"Type <id:{id}> doesn't exist");
			}
			return TypesConstructors[id]() as T;
		}

		[Serializable]
		public class ProtocolTypeNotFoundException : Exception
		{
			public ProtocolTypeNotFoundException()
			{
			}

			public ProtocolTypeNotFoundException(string message) : base(message)
			{
			}

			public ProtocolTypeNotFoundException(string message, Exception inner) : base(message, inner)
			{
			}

			protected ProtocolTypeNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
			{
			}
		}
	}
}