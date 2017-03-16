using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeStartedBidSellerMessage : NetworkMessage
	{
		public const uint Id = 5905;

		public SellerBuyerDescriptor sellerDescriptor;

		public ObjectItemToSellInBid[] objectsInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5905;
			}
		}

		public ExchangeStartedBidSellerMessage()
		{
		}

		public ExchangeStartedBidSellerMessage(SellerBuyerDescriptor sellerDescriptor, ObjectItemToSellInBid[] objectsInfos)
		{
			this.sellerDescriptor = sellerDescriptor;
			this.objectsInfos = objectsInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.sellerDescriptor = new SellerBuyerDescriptor();
			this.sellerDescriptor.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.objectsInfos = new ObjectItemToSellInBid[num];
			for (int i = 0; i < num; i++)
			{
				this.objectsInfos[i] = new ObjectItemToSellInBid();
				this.objectsInfos[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			this.sellerDescriptor.Serialize(writer);
			writer.WriteShort((short)((int)this.objectsInfos.Length));
			ObjectItemToSellInBid[] objectItemToSellInBidArray = this.objectsInfos;
			for (int i = 0; i < (int)objectItemToSellInBidArray.Length; i++)
			{
				objectItemToSellInBidArray[i].Serialize(writer);
			}
		}
	}
}