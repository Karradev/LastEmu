using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeShopStockMovementRemovedMessage : NetworkMessage
	{
		public const uint Id = 5907;

		public uint objectId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5907;
			}
		}

		public ExchangeShopStockMovementRemovedMessage()
		{
		}

		public ExchangeShopStockMovementRemovedMessage(uint objectId)
		{
			this.objectId = objectId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectId);
		}
	}
}