using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeRequestOnMountStockMessage : NetworkMessage
	{
		public const uint Id = 5986;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5986;
			}
		}

		public ExchangeRequestOnMountStockMessage()
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