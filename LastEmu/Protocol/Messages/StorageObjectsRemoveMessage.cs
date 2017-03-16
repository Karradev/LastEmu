using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class StorageObjectsRemoveMessage : NetworkMessage
	{
		public const uint Id = 6035;

		public uint[] objectUIDList;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6035;
			}
		}

		public StorageObjectsRemoveMessage()
		{
		}

		public StorageObjectsRemoveMessage(uint[] objectUIDList)
		{
			this.objectUIDList = objectUIDList;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.objectUIDList = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.objectUIDList[i] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.objectUIDList.Length));
			uint[] numArray = this.objectUIDList;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt((int)numArray[i]);
			}
		}
	}
}