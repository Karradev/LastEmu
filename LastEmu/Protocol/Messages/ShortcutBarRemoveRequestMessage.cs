using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ShortcutBarRemoveRequestMessage : NetworkMessage
	{
		public const uint Id = 6228;

		public sbyte barType;

		public sbyte slot;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6228;
			}
		}

		public ShortcutBarRemoveRequestMessage()
		{
		}

		public ShortcutBarRemoveRequestMessage(sbyte barType, sbyte slot)
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