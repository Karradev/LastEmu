using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseItemRemoveOkMessage : NetworkMessage
	{
		public const uint Id = 5946;

		public int sellerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5946;
			}
		}

		public ExchangeBidHouseItemRemoveOkMessage()
		{
		}

		public ExchangeBidHouseItemRemoveOkMessage(int sellerId)
		{
			this.sellerId = sellerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.sellerId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.sellerId);
		}
	}
}