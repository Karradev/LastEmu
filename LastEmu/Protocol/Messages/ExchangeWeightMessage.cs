using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeWeightMessage : NetworkMessage
	{
		public const uint Id = 5793;

		public uint currentWeight;

		public uint maxWeight;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5793;
			}
		}

		public ExchangeWeightMessage()
		{
		}

		public ExchangeWeightMessage(uint currentWeight, uint maxWeight)
		{
			this.currentWeight = currentWeight;
			this.maxWeight = maxWeight;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.currentWeight = reader.ReadVarUhInt();
			this.maxWeight = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.currentWeight);
			writer.WriteVarInt((int)this.maxWeight);
		}
	}
}