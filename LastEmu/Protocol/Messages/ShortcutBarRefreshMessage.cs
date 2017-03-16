using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ShortcutBarRefreshMessage : NetworkMessage
	{
		public const uint Id = 6229;

		public sbyte barType;

		public Shortcut shortcut;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6229;
			}
		}

		public ShortcutBarRefreshMessage()
		{
		}

		public ShortcutBarRefreshMessage(sbyte barType, Shortcut shortcut)
		{
			this.barType = barType;
			this.shortcut = shortcut;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.barType = reader.ReadSByte();
			this.shortcut = ProtocolTypeManager.GetInstance<Shortcut>(reader.ReadUShort());
			this.shortcut.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.barType);
			writer.WriteShort(this.shortcut.TypeId);
			this.shortcut.Serialize(writer);
		}
	}
}