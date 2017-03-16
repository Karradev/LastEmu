using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeRequestOnShopStockMessage : NetworkMessage
	{
		public const uint Id = 5753;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5753;
			}
		}

		public ExchangeRequestOnShopStockMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}