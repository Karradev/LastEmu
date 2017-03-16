using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectDeletedMessage : NetworkMessage
	{
		public const uint Id = 3024;

		public uint objectUID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3024;
			}
		}

		public ObjectDeletedMessage()
		{
		}

		public ObjectDeletedMessage(uint objectUID)
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