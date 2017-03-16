using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HouseToSellFilterMessage : NetworkMessage
	{
		public const uint Id = 6137;

		public int areaId;

		public sbyte atLeastNbRoom;

		public sbyte atLeastNbChest;

		public uint skillRequested;

		public uint maxPrice;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6137;
			}
		}

		public HouseToSellFilterMessage()
		{
		}

		public HouseToSellFilterMessage(int areaId, sbyte atLeastNbRoom, sbyte atLeastNbChest, uint skillRequested, uint maxPrice)
		{
			this.areaId = areaId;
			this.atLeastNbRoom = atLeastNbRoom;
			this.atLeastNbChest = atLeastNbChest;
			this.skillRequested = skillRequested;
			this.maxPrice = maxPrice;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.areaId = reader.ReadInt();
			this.atLeastNbRoom = reader.ReadSByte();
			this.atLeastNbChest = reader.ReadSByte();
			this.skillRequested = reader.ReadVarUhShort();
			this.maxPrice = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.areaId);
			writer.WriteSByte(this.atLeastNbRoom);
			writer.WriteSByte(this.atLeastNbChest);
			writer.WriteVarShort((int)this.skillRequested);
			writer.WriteVarInt((int)this.maxPrice);
		}
	}
}