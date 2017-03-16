using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LivingObjectChangeSkinRequestMessage : NetworkMessage
	{
		public const uint Id = 5725;

		public uint livingUID;

		public byte livingPosition;

		public uint skinId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5725;
			}
		}

		public LivingObjectChangeSkinRequestMessage()
		{
		}

		public LivingObjectChangeSkinRequestMessage(uint livingUID, byte livingPosition, uint skinId)
		{
			this.livingUID = livingUID;
			this.livingPosition = livingPosition;
			this.skinId = skinId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.livingUID = reader.ReadVarUhInt();
			this.livingPosition = reader.ReadByte();
			this.skinId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.livingUID);
			writer.WriteByte(this.livingPosition);
			writer.WriteVarInt((int)this.skinId);
		}
	}
}