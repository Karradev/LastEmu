using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyUpdateLightMessage : AbstractPartyEventMessage
	{
		public const uint Id = 6054;

		public double id;

		public uint lifePoints;

		public uint maxLifePoints;

		public uint prospecting;

		public byte regenRate;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6054;
			}
		}

		public PartyUpdateLightMessage()
		{
		}

		public PartyUpdateLightMessage(uint partyId, double id, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate) : base(partyId)
		{
			this.id = id;
			this.lifePoints = lifePoints;
			this.maxLifePoints = maxLifePoints;
			this.prospecting = prospecting;
			this.regenRate = regenRate;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadVarUhLong();
			this.lifePoints = reader.ReadVarUhInt();
			this.maxLifePoints = reader.ReadVarUhInt();
			this.prospecting = reader.ReadVarUhShort();
			this.regenRate = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.id);
			writer.WriteVarInt((int)this.lifePoints);
			writer.WriteVarInt((int)this.maxLifePoints);
			writer.WriteVarShort((int)this.prospecting);
			writer.WriteByte(this.regenRate);
		}
	}
}