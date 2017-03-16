using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeObjectModifyPricedMessage : ExchangeObjectMovePricedMessage
	{
		public const uint Id = 6238;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6238;
			}
		}

		public ExchangeObjectModifyPricedMessage()
		{
		}

		public ExchangeObjectModifyPricedMessage(uint objectUID, int quantity, uint price) : base(objectUID, quantity, price)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}