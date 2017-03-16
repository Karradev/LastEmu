using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HouseBuyResultMessage : NetworkMessage
	{
		public const uint Id = 5735;

		public uint houseId;

		public bool bought;

		public uint realPrice;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5735;
			}
		}

		public HouseBuyResultMessage()
		{
		}

		public HouseBuyResultMessage(uint houseId, bool bought, uint realPrice)
		{
			this.houseId = houseId;
			this.bought = bought;
			this.realPrice = realPrice;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.houseId = reader.ReadVarUhInt();
			this.bought = reader.ReadBoolean();
			this.realPrice = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.houseId);
			writer.WriteBoolean(this.bought);
			writer.WriteVarInt((int)this.realPrice);
		}
	}
}