using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AlliancePrismInformation : PrismInformation
	{
		public const short Id = 427;

		public AllianceInformations alliance;

		public override short TypeId
		{
			get
			{
				return 427;
			}
		}

		public AlliancePrismInformation()
		{
		}

		public AlliancePrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount, AllianceInformations alliance) : base(typeId, state, nextVulnerabilityDate, placementDate, rewardTokenCount)
		{
			this.alliance = alliance;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.alliance = new AllianceInformations();
			this.alliance.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.alliance.Serialize(writer);
		}
	}
}