using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseBuyMessage : NetworkMessage
	{
		public const uint Id = 5804;

		public uint uid;

		public uint qty;

		public uint price;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5804;
			}
		}

		public ExchangeBidHouseBuyMessage()
		{
		}

		public ExchangeBidHouseBuyMessage(uint uid, uint qty, uint price)
		{
			this.uid = uid;
			this.qty = qty;
			this.price = price;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.uid = reader.ReadVarUhInt();
			this.qty = reader.ReadVarUhInt();
			this.price = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.uid);
			writer.WriteVarInt((int)this.qty);
			writer.WriteVarInt((int)this.price);
		}
	}
}