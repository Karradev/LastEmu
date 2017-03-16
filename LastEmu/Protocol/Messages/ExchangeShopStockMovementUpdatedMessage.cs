using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeShopStockMovementUpdatedMessage : NetworkMessage
	{
		public const uint Id = 5909;

		public ObjectItemToSell objectInfo;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5909;
			}
		}

		public ExchangeShopStockMovementUpdatedMessage()
		{
		}

		public ExchangeShopStockMovementUpdatedMessage(ObjectItemToSell objectInfo)
		{
			this.objectInfo = objectInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectInfo = new ObjectItemToSell();
			this.objectInfo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.objectInfo.Serialize(writer);
		}
	}
}