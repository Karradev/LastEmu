using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightAllianceTeamInformations : FightTeamInformations
	{
		public const short Id = 439;

		public sbyte relation;

		public override short TypeId
		{
			get
			{
				return 439;
			}
		}

		public FightAllianceTeamInformations()
		{
		}

		public FightAllianceTeamInformations(sbyte teamId, double leaderId, sbyte teamSide, sbyte teamTypeId, sbyte nbWaves, FightTeamMemberInformations[] teamMembers, sbyte relation) : base(teamId, leaderId, teamSide, teamTypeId, nbWaves, teamMembers)
		{
			this.relation = relation;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.relation = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.relation);
		}
	}
}