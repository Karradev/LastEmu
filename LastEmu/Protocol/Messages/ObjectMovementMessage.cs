using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectMovementMessage : NetworkMessage
	{
		public const uint Id = 3010;

		public uint objectUID;

		public byte position;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3010;
			}
		}

		public ObjectMovementMessage()
		{
		}

		public ObjectMovementMessage(uint objectUID, byte position)
		{
			this.objectUID = objectUID;
			this.position = position;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectUID = reader.ReadVarUhInt();
			this.position = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectUID);
			writer.WriteByte(this.position);
		}
	}
}