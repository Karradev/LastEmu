using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildInAllianceFactsMessage : GuildFactsMessage
	{
		public const uint Id = 6422;

		public BasicNamedAllianceInformations allianceInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6422;
			}
		}

		public GuildInAllianceFactsMessage()
		{
		}

		public GuildInAllianceFactsMessage(GuildFactSheetInformations infos, int creationDate, uint nbTaxCollectors, CharacterMinimalInformations[] members, BasicNamedAllianceInformations allianceInfos) : base(infos, creationDate, nbTaxCollectors, members)
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