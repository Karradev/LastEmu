using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeOfflineSoldItemsMessage : NetworkMessage
	{
		public const uint Id = 6613;

		public ObjectItemGenericQuantityPrice[] bidHouseItems;

		public ObjectItemGenericQuantityPrice[] merchantItems;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6613;
			}
		}

		public ExchangeOfflineSoldItemsMessage()
		{
		}

		public ExchangeOfflineSoldItemsMessage(ObjectItemGenericQuantityPrice[] bidHouseItems, ObjectItemGenericQuantityPrice[] merchantItems)
		{
			this.bidHouseItems = bidHouseItems;
			this.merchantItems = merchantItems;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.bidHouseItems = new ObjectItemGenericQuantityPrice[num];
			for (int i = 0; i < num; i++)
			{
				this.bidHouseItems[i] = new ObjectItemGenericQuantityPrice();
				this.bidHouseItems[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.merchantItems = new ObjectItemGenericQuantityPrice[num];
			for (int j = 0; j < num; j++)
			{
				this.merchantItems[j] = new ObjectItemGenericQuantityPrice();
				this.merchantItems[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.bidHouseItems.Length));
			ObjectItemGenericQuantityPrice[] objectItemGenericQuantityPriceArray = this.bidHouseItems;
			for (int i = 0; i < (int)objectItemGenericQuantityPriceArray.Length; i++)
			{
				objectItemGenericQuantityPriceArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.merchantItems.Length));
			ObjectItemGenericQuantityPrice[] objectItemGenericQuantityPriceArray1 = this.merchantItems;
			for (int j = 0; j < (int)objectItemGenericQuantityPriceArray1.Length; j++)
			{
				objectItemGenericQuantityPriceArray1[j].Serialize(writer);
			}
		}
	}
}