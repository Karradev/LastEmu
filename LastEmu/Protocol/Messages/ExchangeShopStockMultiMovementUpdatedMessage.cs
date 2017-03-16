using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeShopStockMultiMovementUpdatedMessage : NetworkMessage
	{
		public const uint Id = 6038;

		public ObjectItemToSell[] objectInfoList;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6038;
			}
		}

		public ExchangeShopStockMultiMovementUpdatedMessage()
		{
		}

		public ExchangeShopStockMultiMovementUpdatedMessage(ObjectItemToSell[] objectInfoList)
		{
			this.objectInfoList = objectInfoList;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.objectInfoList = new ObjectItemToSell[num];
			for (int i = 0; i < num; i++)
			{
				this.objectInfoList[i] = new ObjectItemToSell();
				this.objectInfoList[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.objectInfoList.Length));
			ObjectItemToSell[] objectItemToSellArray = this.objectInfoList;
			for (int i = 0; i < (int)objectItemToSellArray.Length; i++)
			{
				objectItemToSellArray[i].Serialize(writer);
			}
		}
	}
}