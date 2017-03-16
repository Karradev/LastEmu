using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBuyMessage : NetworkMessage
	{
		public const uint Id = 5774;

		public uint objectToBuyId;

		public uint quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5774;
			}
		}

		public ExchangeBuyMessage()
		{
		}

		public ExchangeBuyMessage(uint objectToBuyId, uint quantity)
		{
			this.objectToBuyId = objectToBuyId;
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectToBuyId = reader.ReadVarUhInt();
			this.quantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectToBuyId);
			writer.WriteVarInt((int)this.quantity);
		}
	}
}