using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LivingObjectDissociateMessage : NetworkMessage
	{
		public const uint Id = 5723;

		public uint livingUID;

		public byte livingPosition;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5723;
			}
		}

		public LivingObjectDissociateMessage()
		{
		}

		public LivingObjectDissociateMessage(uint livingUID, byte livingPosition)
		{
			this.livingUID = livingUID;
			this.livingPosition = livingPosition;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.livingUID = reader.ReadVarUhInt();
			this.livingPosition = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.livingUID);
			writer.WriteByte(this.livingPosition);
		}
	}
}