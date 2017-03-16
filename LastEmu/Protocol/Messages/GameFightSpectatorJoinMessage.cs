using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameFightSpectatorJoinMessage : GameFightJoinMessage
	{
		public const uint Id = 6504;

		public NamedPartyTeam[] namedPartyTeams;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6504;
			}
		}

		public GameFightSpectatorJoinMessage()
		{
		}

		public GameFightSpectatorJoinMessage(bool isTeamPhase, bool canBeCancelled, bool canSayReady, bool isFightStarted, short timeMaxBeforeFightStart, sbyte fightType, NamedPartyTeam[] namedPartyTeams) : base(isTeamPhase, canBeCancelled, canSayReady, isFightStarted, timeMaxBeforeFightStart, fightType)
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