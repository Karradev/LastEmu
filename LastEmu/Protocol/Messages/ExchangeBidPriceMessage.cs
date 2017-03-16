using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidPriceMessage : NetworkMessage
	{
		public const uint Id = 5755;

		public uint genericId;

		public int averagePrice;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5755;
			}
		}

		public ExchangeBidPriceMessage()
		{
		}

		public ExchangeBidPriceMessage(uint genericId, int averagePrice)
		{
			this.genericId = genericId;
			this.averagePrice = averagePrice;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.genericId = reader.ReadVarUhShort();
			this.averagePrice = reader.ReadVarInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.genericId);
			writer.WriteVarInt(this.averagePrice);
		}
	}
}