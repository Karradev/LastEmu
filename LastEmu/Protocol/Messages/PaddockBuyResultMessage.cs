using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PaddockBuyResultMessage : NetworkMessage
	{
		public const uint Id = 6516;

		public int paddockId;

		public bool bought;

		public uint realPrice;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6516;
			}
		}

		public PaddockBuyResultMessage()
		{
		}

		public PaddockBuyResultMessage(int paddockId, bool bought, uint realPrice)
		{
			this.paddockId = paddockId;
			this.bought = bought;
			this.realPrice = realPrice;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.paddockId = reader.ReadInt();
			this.bought = reader.ReadBoolean();
			this.realPrice = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.paddockId);
			writer.WriteBoolean(this.bought);
			writer.WriteVarInt((int)this.realPrice);
		}
	}
}