using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PaddockSellRequestMessage : NetworkMessage
	{
		public const uint Id = 5953;

		public uint price;

		public bool forSale;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5953;
			}
		}

		public PaddockSellRequestMessage()
		{
		}

		public PaddockSellRequestMessage(uint price, bool forSale)
		{
			this.price = price;
			this.forSale = forSale;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.price = reader.ReadVarUhInt();
			this.forSale = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.price);
			writer.WriteBoolean(this.forSale);
		}
	}
}