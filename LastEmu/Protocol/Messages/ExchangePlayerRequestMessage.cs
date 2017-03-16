using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangePlayerRequestMessage : ExchangeRequestMessage
	{
		public const uint Id = 5773;

		public double target;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5773;
			}
		}

		public ExchangePlayerRequestMessage()
		{
		}

		public ExchangePlayerRequestMessage(sbyte exchangeType, double target) : base(exchangeType)
		{
			this.target = target;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.target = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.target);
		}
	}
}