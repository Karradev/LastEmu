using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseInListRemovedMessage : NetworkMessage
	{
		public const uint Id = 5950;

		public int itemUID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5950;
			}
		}

		public ExchangeBidHouseInListRemovedMessage()
		{
		}

		public ExchangeBidHouseInListRemovedMessage(int itemUID)
		{
			this.itemUID = itemUID;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.itemUID = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.itemUID);
		}
	}
}