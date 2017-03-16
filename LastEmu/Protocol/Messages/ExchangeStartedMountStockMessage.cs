using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeStartedMountStockMessage : NetworkMessage
	{
		public const uint Id = 5984;

		public ObjectItem[] objectsInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5984;
			}
		}

		public ExchangeStartedMountStockMessage()
		{
		}

		public ExchangeStartedMountStockMessage(ObjectItem[] objectsInfos)
		{
			this.objectsInfos = objectsInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.objectsInfos = new ObjectItem[num];
			for (int i = 0; i < num; i++)
			{
				this.objectsInfos[i] = new ObjectItem();
				this.objectsInfos[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.objectsInfos.Length));
			ObjectItem[] objectItemArray = this.objectsInfos;
			for (int i = 0; i < (int)objectItemArray.Length; i++)
			{
				objectItemArray[i].Serialize(writer);
			}
		}
	}
}