using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeStartedMessage : NetworkMessage
	{
		public const uint Id = 5512;

		public sbyte exchangeType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5512;
			}
		}

		public ExchangeStartedMessage()
		{
		}

		public ExchangeStartedMessage(sbyte exchangeType)
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