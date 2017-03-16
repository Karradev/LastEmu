using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AlliancedGuildFactSheetInformations : GuildInformations
	{
		public const short Id = 422;

		public BasicNamedAllianceInformations allianceInfos;

		public override short TypeId
		{
			get
			{
				return 422;
			}
		}

		public AlliancedGuildFactSheetInformations()
		{
		}

		public AlliancedGuildFactSheetInformations(uint guildId, string guildName, byte guildLevel, GuildEmblem guildEmblem, BasicNamedAllianceInformations allianceInfos) : base(guildId, guildName, guildLevel, guildEmblem)
		{
			this.allianceInfos = allianceInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.allianceInfos = new BasicNamedAllianceInformations();
			this.allianceInfos.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.allianceInfos.Serialize(writer);
		}
	}
}