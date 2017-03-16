using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class FightTeamInformations : AbstractFightTeamInformations
	{
		public const short Id = 33;

		public FightTeamMemberInformations[] teamMembers;

		public override short TypeId
		{
			get
			{
				return 33;
			}
		}

		public FightTeamInformations()
		{
		}

		public FightTeamInformations(sbyte teamId, double leaderId, sbyte teamSide, sbyte teamTypeId, sbyte nbWaves, FightTeamMemberInformations[] teamMembers) : base(teamId, leaderId, teamSide, teamTypeId, nbWaves)
		{
			this.teamMembers = teamMembers;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.teamMembers = new FightTeamMemberInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.teamMembers[i] = ProtocolTypeManager.GetInstance<FightTeamMemberInformations>(reader.ReadUShort());
				this.teamMembers[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.teamMembers.Length));
			FightTeamMemberInformations[] fightTeamMemberInformationsArray = this.teamMembers;
			for (int i = 0; i < (int)fightTeamMemberInformationsArray.Length; i++)
			{
				FightTeamMemberInformations fightTeamMemberInformation = fightTeamMemberInformationsArray[i];
				writer.WriteShort(fightTeamMemberInformation.TypeId);
				fightTeamMemberInformation.Serialize(writer);
			}
		}
	}
}