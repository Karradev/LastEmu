using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class InventoryWeightMessage : NetworkMessage
	{
		public const uint Id = 3009;

		public uint weight;

		public uint weightMax;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3009;
			}
		}

		public InventoryWeightMessage()
		{
		}

		public InventoryWeightMessage(uint weight, uint weightMax)
		{
			this.weight = weight;
			this.weightMax = weightMax;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.weight = reader.ReadVarUhInt();
			this.weightMax = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.weight);
			writer.WriteVarInt((int)this.weightMax);
		}
	}
}