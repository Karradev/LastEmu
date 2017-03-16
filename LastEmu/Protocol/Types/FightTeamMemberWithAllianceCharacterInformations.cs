using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTeamMemberWithAllianceCharacterInformations : FightTeamMemberCharacterInformations
	{
		public const short Id = 426;

		public BasicAllianceInformations allianceInfos;

		public override short TypeId
		{
			get
			{
				return 426;
			}
		}

		public FightTeamMemberWithAllianceCharacterInformations()
		{
		}

		public FightTeamMemberWithAllianceCharacterInformations(double id, string name, byte level, BasicAllianceInformations allianceInfos) : base(id, name, level)
		{
			this.allianceInfos = allianceInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.allianceInfos = new BasicAllianceInformations();
			this.allianceInfos.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.allianceInfos.Serialize(writer);
		}
	}
}