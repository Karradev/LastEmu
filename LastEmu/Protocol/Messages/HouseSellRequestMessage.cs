using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HouseSellRequestMessage : NetworkMessage
	{
		public const uint Id = 5697;

		public uint amount;

		public bool forSale;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5697;
			}
		}

		public HouseSellRequestMessage()
		{
		}

		public HouseSellRequestMessage(uint amount, bool forSale)
		{
			this.amount = amount;
			this.forSale = forSale;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.amount = reader.ReadVarUhInt();
			this.forSale = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.amount);
			writer.WriteBoolean(this.forSale);
		}
	}
}