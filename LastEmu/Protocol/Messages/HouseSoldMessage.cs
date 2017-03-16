using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HouseSoldMessage : NetworkMessage
	{
		public const uint Id = 5737;

		public uint houseId;

		public uint realPrice;

		public string buyerName;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5737;
			}
		}

		public HouseSoldMessage()
		{
		}

		public HouseSoldMessage(uint houseId, uint realPrice, string buyerName)
		{
			this.houseId = houseId;
			this.realPrice = realPrice;
			this.buyerName = buyerName;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.houseId = reader.ReadVarUhInt();
			this.realPrice = reader.ReadVarUhInt();
			this.buyerName = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.houseId);
			writer.WriteVarInt((int)this.realPrice);
			writer.WriteUTF(this.buyerName);
		}
	}
}