using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ShortcutBarContentMessage : NetworkMessage
	{
		public const uint Id = 6231;

		public sbyte barType;

		public Shortcut[] shortcuts;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6231;
			}
		}

		public ShortcutBarContentMessage()
		{
		}

		public ShortcutBarContentMessage(sbyte barType, Shortcut[] shortcuts)
		{
			this.barType = barType;
			this.shortcuts = shortcuts;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.barType = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.shortcuts = new Shortcut[num];
			for (int i = 0; i < num; i++)
			{
				this.shortcuts[i] = ProtocolTypeManager.GetInstance<Shortcut>(reader.ReadUShort());
				this.shortcuts[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.barType);
			writer.WriteShort((short)((int)this.shortcuts.Length));
			Shortcut[] shortcutArray = this.shortcuts;
			for (int i = 0; i < (int)shortcutArray.Length; i++)
			{
				Shortcut shortcut = shortcutArray[i];
				writer.WriteShort(shortcut.TypeId);
				shortcut.Serialize(writer);
			}
		}
	}
}