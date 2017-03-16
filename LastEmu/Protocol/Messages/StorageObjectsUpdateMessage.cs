using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class StorageObjectsUpdateMessage : NetworkMessage
	{
		public const uint Id = 6036;

		public ObjectItem[] objectList;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6036;
			}
		}

		public StorageObjectsUpdateMessage()
		{
		}

		public StorageObjectsUpdateMessage(ObjectItem[] objectList)
		{
			this.objectList = objectList;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.objectList = new ObjectItem[num];
			for (int i = 0; i < num; i++)
			{
				this.objectList[i] = new ObjectItem();
				this.objectList[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.objectList.Length));
			ObjectItem[] objectItemArray = this.objectList;
			for (int i = 0; i < (int)objectItemArray.Length; i++)
			{
				objectItemArray[i].Serialize(writer);
			}
		}
	}
}