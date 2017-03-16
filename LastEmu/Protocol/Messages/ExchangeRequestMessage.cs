using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeRequestMessage : NetworkMessage
	{
		public const uint Id = 5505;

		public sbyte exchangeType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5505;
			}
		}

		public ExchangeRequestMessage()
		{
		}

		public ExchangeRequestMessage(sbyte exchangeType)
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