using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeObjectMovePricedMessage : ExchangeObjectMoveMessage
	{
		public const uint Id = 5514;

		public uint price;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5514;
			}
		}

		public ExchangeObjectMovePricedMessage()
		{
		}

		public ExchangeObjectMovePricedMessage(uint objectUID, int quantity, uint price) : base(objectUID, quantity)
		{
			this.price = price;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.price = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.price);
		}
	}
}