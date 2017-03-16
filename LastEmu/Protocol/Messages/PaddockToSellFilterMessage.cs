using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PaddockToSellFilterMessage : NetworkMessage
	{
		public const uint Id = 6161;

		public int areaId;

		public sbyte atLeastNbMount;

		public sbyte atLeastNbMachine;

		public uint maxPrice;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6161;
			}
		}

		public PaddockToSellFilterMessage()
		{
		}

		public PaddockToSellFilterMessage(int areaId, sbyte atLeastNbMount, sbyte atLeastNbMachine, uint maxPrice)
		{
			this.areaId = areaId;
			this.atLeastNbMount = atLeastNbMount;
			this.atLeastNbMachine = atLeastNbMachine;
			this.maxPrice = maxPrice;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.areaId = reader.ReadInt();
			this.atLeastNbMount = reader.ReadSByte();
			this.atLeastNbMachine = reader.ReadSByte();
			this.maxPrice = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.areaId);
			writer.WriteSByte(this.atLeastNbMount);
			writer.WriteSByte(this.atLeastNbMachine);
			writer.WriteVarInt((int)this.maxPrice);
		}
	}
}