using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeSellMessage : NetworkMessage
	{
		public const uint Id = 5778;

		public uint objectToSellId;

		public uint quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5778;
			}
		}

		public ExchangeSellMessage()
		{
		}

		public ExchangeSellMessage(uint objectToSellId, uint quantity)
		{
			this.objectToSellId = objectToSellId;
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectToSellId = reader.ReadVarUhInt();
			this.quantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectToSellId);
			writer.WriteVarInt((int)this.quantity);
		}
	}
}