using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkRunesTradeMessage : NetworkMessage
	{
		public const uint Id = 6567;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6567;
			}
		}

		public ExchangeStartOkRunesTradeMessage()
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