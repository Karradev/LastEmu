using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PartyMemberArenaInformations : PartyMemberInformations
	{
		public const short Id = 391;

		public uint rank;

		public override short TypeId
		{
			get
			{
				return 391;
			}
		}

		public PartyMemberArenaInformations()
		{
		}

		public PartyMemberArenaInformations(double id, string name, byte level, EntityLook entityLook, sbyte breed, bool sex, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate, uint initiative, sbyte alignmentSide, short worldX, short worldY, int mapId, uint subAreaId, PlayerStatus status, PartyCompanionMemberInformations[] companions, uint rank) : base(id, name, level, entityLook, breed, sex, lifePoints, maxLifePoints, prospecting, regenRate, initiative, alignmentSide, worldX, worldY, mapId, subAreaId, status, companions)
		{
			this.rank = rank;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.rank = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.rank);
		}
	}
}