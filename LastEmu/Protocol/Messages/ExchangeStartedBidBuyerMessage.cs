using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeStartedBidBuyerMessage : NetworkMessage
	{
		public const uint Id = 5904;

		public SellerBuyerDescriptor buyerDescriptor;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5904;
			}
		}

		public ExchangeStartedBidBuyerMessage()
		{
		}

		public ExchangeStartedBidBuyerMessage(SellerBuyerDescriptor buyerDescriptor)
		{
			this.buyerDescriptor = buyerDescriptor;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.buyerDescriptor = new SellerBuyerDescriptor();
			this.buyerDescriptor.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.buyerDescriptor.Serialize(writer);
		}
	}
}