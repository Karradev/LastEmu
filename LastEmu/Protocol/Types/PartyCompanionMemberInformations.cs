using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PartyCompanionMemberInformations : PartyCompanionBaseInformations
	{
		public const short Id = 452;

		public uint initiative;

		public uint lifePoints;

		public uint maxLifePoints;

		public uint prospecting;

		public byte regenRate;

		public override short TypeId
		{
			get
			{
				return 452;
			}
		}

		public PartyCompanionMemberInformations()
		{
		}

		public PartyCompanionMemberInformations(sbyte indexId, sbyte companionGenericId, EntityLook entityLook, uint initiative, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate) : base(indexId, companionGenericId, entityLook)
		{
			this.initiative = initiative;
			this.lifePoints = lifePoints;
			this.maxLifePoints = maxLifePoints;
			this.prospecting = prospecting;
			this.regenRate = regenRate;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.initiative = reader.ReadVarUhShort();
			this.lifePoints = reader.ReadVarUhInt();
			this.maxLifePoints = reader.ReadVarUhInt();
			this.prospecting = reader.ReadVarUhShort();
			this.regenRate = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.initiative);
			writer.WriteVarInt((int)this.lifePoints);
			writer.WriteVarInt((int)this.maxLifePoints);
			writer.WriteVarShort((int)this.prospecting);
			writer.WriteByte(this.regenRate);
		}
	}
}