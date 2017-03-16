using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TaxCollectorStaticExtendedInformations : TaxCollectorStaticInformations
	{
		public const short Id = 440;

		public AllianceInformations allianceIdentity;

		public override short TypeId
		{
			get
			{
				return 440;
			}
		}

		public TaxCollectorStaticExtendedInformations()
		{
		}

		public TaxCollectorStaticExtendedInformations(uint firstNameId, uint lastNameId, GuildInformations guildIdentity, AllianceInformations allianceIdentity) : base(firstNameId, lastNameId, guildIdentity)
		{
			this.allianceIdentity = allianceIdentity;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.allianceIdentity = new AllianceInformations();
			this.allianceIdentity.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.allianceIdentity.Serialize(writer);
		}
	}
}