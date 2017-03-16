using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkHumanVendorMessage : NetworkMessage
	{
		public const uint Id = 5767;

		public double sellerId;

		public ObjectItemToSellInHumanVendorShop[] objectsInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5767;
			}
		}

		public ExchangeStartOkHumanVendorMessage()
		{
		}

		public ExchangeStartOkHumanVendorMessage(double sellerId, ObjectItemToSellInHumanVendorShop[] objectsInfos)
		{
			this.sellerId = sellerId;
			this.objectsInfos = objectsInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.sellerId = reader.ReadDouble();
			ushort num = reader.ReadUShort();
			this.objectsInfos = new ObjectItemToSellInHumanVendorShop[num];
			for (int i = 0; i < num; i++)
			{
				this.objectsInfos[i] = new ObjectItemToSellInHumanVendorShop();
				this.objectsInfos[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.sellerId);
			writer.WriteShort((short)((int)this.objectsInfos.Length));
			ObjectItemToSellInHumanVendorShop[] objectItemToSellInHumanVendorShopArray = this.objectsInfos;
			for (int i = 0; i < (int)objectItemToSellInHumanVendorShopArray.Length; i++)
			{
				objectItemToSellInHumanVendorShopArray[i].Serialize(writer);
			}
		}
	}
}