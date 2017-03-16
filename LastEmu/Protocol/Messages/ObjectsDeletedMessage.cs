using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectsDeletedMessage : NetworkMessage
	{
		public const uint Id = 6034;

		public uint[] objectUID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6034;
			}
		}

		public ObjectsDeletedMessage()
		{
		}

		public ObjectsDeletedMessage(uint[] objectUID)
		{
			this.objectUID = objectUID;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.objectUID = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.objectUID[i] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.objectUID.Length));
			uint[] numArray = this.objectUID;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt((int)numArray[i]);
			}
		}
	}
}