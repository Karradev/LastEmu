using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeRequestedMessage : NetworkMessage
	{
		public const uint Id = 5522;

		public sbyte exchangeType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5522;
			}
		}

		public ExchangeRequestedMessage()
		{
		}

		public ExchangeRequestedMessage(sbyte exchangeType)
		{
			this.exchangeType = exchangeType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.exchangeType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.exchangeType);
		}
	}
}