using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectFeedMessage : NetworkMessage
	{
		public const uint Id = 6290;

		public uint objectUID;

		public uint foodUID;

		public uint foodQuantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6290;
			}
		}

		public ObjectFeedMessage()
		{
		}

		public ObjectFeedMessage(uint objectUID, uint foodUID, uint foodQuantity)
		{
			this.objectUID = objectUID;
			this.foodUID = foodUID;
			this.foodQuantity = foodQuantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectUID = reader.ReadVarUhInt();
			this.foodUID = reader.ReadVarUhInt();
			this.foodQuantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectUID);
			writer.WriteVarInt((int)this.foodUID);
			writer.WriteVarInt((int)this.foodQuantity);
		}
	}
}