using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkNpcShopMessage : NetworkMessage
	{
		public const uint Id = 5761;

		public double npcSellerId;

		public uint tokenId;

		public ObjectItemToSellInNpcShop[] objectsInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5761;
			}
		}

		public ExchangeStartOkNpcShopMessage()
		{
		}

		public ExchangeStartOkNpcShopMessage(double npcSellerId, uint tokenId, ObjectItemToSellInNpcShop[] objectsInfos)
		{
			this.npcSellerId = npcSellerId;
			this.tokenId = tokenId;
			this.objectsInfos = objectsInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.npcSellerId = reader.ReadDouble();
			this.tokenId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.objectsInfos = new ObjectItemToSellInNpcShop[num];
			for (int i = 0; i < num; i++)
			{
				this.objectsInfos[i] = new ObjectItemToSellInNpcShop();
				this.objectsInfos[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.npcSellerId);
			writer.WriteVarShort((int)this.tokenId);
			writer.WriteShort((short)((int)this.objectsInfos.Length));
			ObjectItemToSellInNpcShop[] objectItemToSellInNpcShopArray = this.objectsInfos;
			for (int i = 0; i < (int)objectItemToSellInNpcShopArray.Length; i++)
			{
				objectItemToSellInNpcShopArray[i].Serialize(writer);
			}
		}
	}
}