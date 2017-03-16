using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeSellOkMessage : NetworkMessage
	{
		public const uint Id = 5792;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5792;
			}
		}

		public ExchangeSellOkMessage()
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