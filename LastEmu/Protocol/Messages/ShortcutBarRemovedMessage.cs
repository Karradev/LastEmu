using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ShortcutBarRemovedMessage : NetworkMessage
	{
		public const uint Id = 6224;

		public sbyte barType;

		public sbyte slot;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6224;
			}
		}

		public ShortcutBarRemovedMessage()
		{
		}

		public ShortcutBarRemovedMessage(sbyte barType, sbyte slot)
		{
			this.barType = barType;
			this.slot = slot;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.barType = reader.ReadSByte();
			this.slot = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.barType);
			writer.WriteSByte(this.slot);
		}
	}
}