using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PurchasableDialogMessage : NetworkMessage
	{
		public const uint Id = 5739;

		public bool buyOrSell;

		public uint purchasableId;

		public uint price;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5739;
			}
		}

		public PurchasableDialogMessage()
		{
		}

		public PurchasableDialogMessage(bool buyOrSell, uint purchasableId, uint price)
		{
			this.buyOrSell = buyOrSell;
			this.purchasableId = purchasableId;
			this.price = price;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.buyOrSell = reader.ReadBoolean();
			this.purchasableId = reader.ReadVarUhInt();
			this.price = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.buyOrSell);
			writer.WriteVarInt((int)this.purchasableId);
			writer.WriteVarInt((int)this.price);
		}
	}
}