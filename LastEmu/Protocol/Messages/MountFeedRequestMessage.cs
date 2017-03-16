using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountFeedRequestMessage : NetworkMessage
	{
		public const uint Id = 6189;

		public uint mountUid;

		public sbyte mountLocation;

		public uint mountFoodUid;

		public uint quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6189;
			}
		}

		public MountFeedRequestMessage()
		{
		}

		public MountFeedRequestMessage(uint mountUid, sbyte mountLocation, uint mountFoodUid, uint quantity)
		{
			this.mountUid = mountUid;
			this.mountLocation = mountLocation;
			this.mountFoodUid = mountFoodUid;
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.mountUid = reader.ReadVarUhInt();
			this.mountLocation = reader.ReadSByte();
			this.mountFoodUid = reader.ReadVarUhInt();
			this.quantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.mountUid);
			writer.WriteSByte(this.mountLocation);
			writer.WriteVarInt((int)this.mountFoodUid);
			writer.WriteVarInt((int)this.quantity);
		}
	}
}