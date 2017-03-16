using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectSetPositionMessage : NetworkMessage
	{
		public const uint Id = 3021;

		public uint objectUID;

		public byte position;

		public uint quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3021;
			}
		}

		public ObjectSetPositionMessage()
		{
		}

		public ObjectSetPositionMessage(uint objectUID, byte position, uint quantity)
		{
			this.objectUID = objectUID;
			this.position = position;
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectUID = reader.ReadVarUhInt();
			this.position = reader.ReadByte();
			this.quantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectUID);
			writer.WriteByte(this.position);
			writer.WriteVarInt((int)this.quantity);
		}
	}
}