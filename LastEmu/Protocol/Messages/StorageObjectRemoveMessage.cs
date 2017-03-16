using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class StorageObjectRemoveMessage : NetworkMessage
	{
		public const uint Id = 5648;

		public uint objectUID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5648;
			}
		}

		public StorageObjectRemoveMessage()
		{
		}

		public StorageObjectRemoveMessage(uint objectUID)
		{
			this.objectUID = objectUID;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectUID = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectUID);
		}
	}
}