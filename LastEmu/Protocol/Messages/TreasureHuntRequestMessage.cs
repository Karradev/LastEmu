using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TreasureHuntRequestMessage : NetworkMessage
	{
		public const uint Id = 6488;

		public byte questLevel;

		public sbyte questType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6488;
			}
		}

		public TreasureHuntRequestMessage()
		{
		}

		public TreasureHuntRequestMessage(byte questLevel, sbyte questType)
		{
			this.questLevel = questLevel;
			this.questType = questType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.questLevel = reader.ReadByte();
			this.questType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteByte(this.questLevel);
			writer.WriteSByte(this.questType);
		}
	}
}