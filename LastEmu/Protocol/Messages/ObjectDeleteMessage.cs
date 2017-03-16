using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectDeleteMessage : NetworkMessage
	{
		public const uint Id = 3022;

		public uint objectUID;

		public uint quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3022;
			}
		}

		public ObjectDeleteMessage()
		{
		}

		public ObjectDeleteMessage(uint objectUID, uint quantity)
		{
			this.objectUID = objectUID;
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectUID = reader.ReadVarUhInt();
			this.quantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectUID);
			writer.WriteVarInt((int)this.quantity);
		}
	}
}