using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeBidPriceForSellerMessage : ExchangeBidPriceMessage
	{
		public const uint Id = 6464;

		public bool allIdentical;

		public uint[] minimalPrices;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6464;
			}
		}

		public ExchangeBidPriceForSellerMessage()
		{
		}

		public ExchangeBidPriceForSellerMessage(uint genericId, int averagePrice, bool allIdentical, uint[] minimalPrices) : base(genericId, averagePrice)
		{
			this.allIdentical = allIdentical;
			this.minimalPrices = minimalPrices;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.allIdentical = reader.ReadBoolean();
			ushort num = reader.ReadUShort();
			this.minimalPrices = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.minimalPrices[i] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(this.allIdentical);
			writer.WriteShort((short)((int)this.minimalPrices.Length));
			uint[] numArray = this.minimalPrices;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt((int)numArray[i]);
			}
		}
	}
}