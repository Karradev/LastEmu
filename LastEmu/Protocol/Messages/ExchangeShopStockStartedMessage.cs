using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeShopStockStartedMessage : NetworkMessage
	{
		public const uint Id = 5910;

		public ObjectItemToSell[] objectsInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5910;
			}
		}

		public ExchangeShopStockStartedMessage()
		{
		}

		public ExchangeShopStockStartedMessage(ObjectItemToSell[] objectsInfos)
		{
			this.objectsInfos = objectsInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.objectsInfos = new ObjectItemToSell[num];
			for (int i = 0; i < num; i++)
			{
				this.objectsInfos[i] = new ObjectItemToSell();
				this.objectsInfos[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.objectsInfos.Length));
			ObjectItemToSell[] objectItemToSellArray = this.objectsInfos;
			for (int i = 0; i < (int)objectItemToSellArray.Length; i++)
			{
				objectItemToSellArray[i].Serialize(writer);
			}
		}
	}
}