using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeObjectUseInWorkshopMessage : NetworkMessage
	{
		public const uint Id = 6004;

		public uint objectUID;

		public int quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6004;
			}
		}

		public ExchangeObjectUseInWorkshopMessage()
		{
		}

		public ExchangeObjectUseInWorkshopMessage(uint objectUID, int quantity)
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