using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PaddockSellBuyDialogMessage : NetworkMessage
	{
		public const uint Id = 6018;

		public bool bsell;

		public uint ownerId;

		public uint price;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6018;
			}
		}

		public PaddockSellBuyDialogMessage()
		{
		}

		public PaddockSellBuyDialogMessage(bool bsell, uint ownerId, uint price)
		{
			this.bsell = bsell;
			this.ownerId = ownerId;
			this.price = price;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.bsell = reader.ReadBoolean();
			this.ownerId = reader.ReadVarUhInt();
			this.price = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.bsell);
			writer.WriteVarInt((int)this.ownerId);
			writer.WriteVarInt((int)this.price);
		}
	}
}