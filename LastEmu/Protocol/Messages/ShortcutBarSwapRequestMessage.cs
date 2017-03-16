using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ShortcutBarSwapRequestMessage : NetworkMessage
	{
		public const uint Id = 6230;

		public sbyte barType;

		public sbyte firstSlot;

		public sbyte secondSlot;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6230;
			}
		}

		public ShortcutBarSwapRequestMessage()
		{
		}

		public ShortcutBarSwapRequestMessage(sbyte barType, sbyte firstSlot, sbyte secondSlot)
		{
			this.barType = barType;
			this.firstSlot = firstSlot;
			this.secondSlot = secondSlot;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.barType = reader.ReadSByte();
			this.firstSlot = reader.ReadSByte();
			this.secondSlot = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.barType);
			writer.WriteSByte(this.firstSlot);
			writer.WriteSByte(this.secondSlot);
		}
	}
}