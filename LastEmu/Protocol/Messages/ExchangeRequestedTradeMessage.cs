using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeRequestedTradeMessage : ExchangeRequestedMessage
	{
		public const uint Id = 5523;

		public double source;

		public double target;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5523;
			}
		}

		public ExchangeRequestedTradeMessage()
		{
		}

		public ExchangeRequestedTradeMessage(sbyte exchangeType, double source, double target) : base(exchangeType)
		{
			this.source = source;
			this.target = target;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.source = reader.ReadVarUhLong();
			this.target = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.source);
			writer.WriteVarLong(this.target);
		}
	}
}