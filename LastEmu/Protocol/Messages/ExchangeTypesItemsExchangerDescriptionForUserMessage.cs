using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeTypesItemsExchangerDescriptionForUserMessage : NetworkMessage
	{
		public const uint Id = 5752;

		public BidExchangerObjectInfo[] itemTypeDescriptions;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5752;
			}
		}

		public ExchangeTypesItemsExchangerDescriptionForUserMessage()
		{
		}

		public ExchangeTypesItemsExchangerDescriptionForUserMessage(BidExchangerObjectInfo[] itemTypeDescriptions)
		{
			this.itemTypeDescriptions = itemTypeDescriptions;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.itemTypeDescriptions = new BidExchangerObjectInfo[num];
			for (int i = 0; i < num; i++)
			{
				this.itemTypeDescriptions[i] = new BidExchangerObjectInfo();
				this.itemTypeDescriptions[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.itemTypeDescriptions.Length));
			BidExchangerObjectInfo[] bidExchangerObjectInfoArray = this.itemTypeDescriptions;
			for (int i = 0; i < (int)bidExchangerObjectInfoArray.Length; i++)
			{
				bidExchangerObjectInfoArray[i].Serialize(writer);
			}
		}
	}
}