using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectQuantityMessage : NetworkMessage
	{
		public const uint Id = 3023;

		public uint objectUID;

		public uint quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3023;
			}
		}

		public ObjectQuantityMessage()
		{
		}

		public ObjectQuantityMessage(uint objectUID, uint quantity)
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