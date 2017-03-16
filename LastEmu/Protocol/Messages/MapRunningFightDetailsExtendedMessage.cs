using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MapRunningFightDetailsExtendedMessage : MapRunningFightDetailsMessage
	{
		public const uint Id = 6500;

		public NamedPartyTeam[] namedPartyTeams;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6500;
			}
		}

		public MapRunningFightDetailsExtendedMessage()
		{
		}

		public MapRunningFightDetailsExtendedMessage(int fightId, GameFightFighterLightInformations[] attackers, GameFightFighterLightInformations[] defenders, NamedPartyTeam[] namedPartyTeams) : base(fightId, attackers, defenders)
		{
			this.namedPartyTeams = namedPartyTeams;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.namedPartyTeams = new NamedPartyTeam[num];
			for (int i = 0; i < num; i++)
			{
				this.namedPartyTeams[i] = new NamedPartyTeam();
				this.namedPartyTeams[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.namedPartyTeams.Length));
			NamedPartyTeam[] namedPartyTeamArray = this.namedPartyTeams;
			for (int i = 0; i < (int)namedPartyTeamArray.Length; i++)
			{
				namedPartyTeamArray[i].Serialize(writer);
			}
		}
	}
}