using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseUnsoldItemsMessage : NetworkMessage
	{
		public const uint Id = 6612;

		public ObjectItemGenericQuantity[] items;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6612;
			}
		}

		public ExchangeBidHouseUnsoldItemsMessage()
		{
		}

		public ExchangeBidHouseUnsoldItemsMessage(ObjectItemGenericQuantity[] items)
		{
			this.items = items;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.items = new ObjectItemGenericQuantity[num];
			for (int i = 0; i < num; i++)
			{
				this.items[i] = new ObjectItemGenericQuantity();
				this.items[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.items.Length));
			ObjectItemGenericQuantity[] objectItemGenericQuantityArray = this.items;
			for (int i = 0; i < (int)objectItemGenericQuantityArray.Length; i++)
			{
				objectItemGenericQuantityArray[i].Serialize(writer);
			}
		}
	}
}