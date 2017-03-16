using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeObjectMoveMessage : NetworkMessage
	{
		public const uint Id = 5518;

		public uint objectUID;

		public int quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5518;
			}
		}

		public ExchangeObjectMoveMessage()
		{
		}

		public ExchangeObjectMoveMessage(uint objectUID, int quantity)
		{
			this.objectUID = objectUID;
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectUID = reader.ReadVarUhInt();
			this.quantity = reader.ReadVarInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectUID);
			writer.WriteVarInt(this.quantity);
		}
	}
}