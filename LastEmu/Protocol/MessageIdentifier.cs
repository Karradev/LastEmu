using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Protocol
{
    public static class MessageIdentifier
    {
        private static readonly Dictionary<uint, string> Packets = new Dictionary<uint, string>();

        public static void Initialize()
        {
            var asm = Assembly.GetAssembly(typeof (MessageIdentifier));
            foreach (var type in asm.GetTypes().Where(entry => entry.IsSubclassOf(typeof (NetworkMessage))))
            {
                var property = type.GetProperty("ProtocolId");
                if(property == null) continue;
                var num = (uint) property.GetValue(Activator.CreateInstance(type), null);
                if(Packets.ContainsKey(num)) continue;
                Packets.Add(num, type.Name);
            }
        }

        public static string GetMessageName(uint id) => Packets[id];
    }
}
