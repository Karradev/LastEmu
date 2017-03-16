using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TreasureHuntAvailableRetryCountUpdateMessage : NetworkMessage
	{
		public const uint Id = 6491;

		public sbyte questType;

		public int availableRetryCount;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6491;
			}
		}

		public TreasureHuntAvailableRetryCountUpdateMessage()
		{
		}

		public TreasureHuntAvailableRetryCountUpdateMessage(sbyte questType, int availableRetryCount)
		{
			this.questType = questType;
			this.availableRetryCount = availableRetryCount;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.questType = reader.ReadSByte();
			this.availableRetryCount = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.questType);
			writer.WriteInt(this.availableRetryCount);
		}
	}
}