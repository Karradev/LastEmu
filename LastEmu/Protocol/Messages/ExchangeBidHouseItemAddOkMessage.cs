using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseItemAddOkMessage : NetworkMessage
	{
		public const uint Id = 5945;

		public ObjectItemToSellInBid itemInfo;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5945;
			}
		}

		public ExchangeBidHouseItemAddOkMessage()
		{
		}

		public ExchangeBidHouseItemAddOkMessage(ObjectItemToSellInBid itemInfo)
		{
			this.itemInfo = itemInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.itemInfo = new ObjectItemToSellInBid();
			this.itemInfo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.itemInfo.Serialize(writer);
		}
	}
}