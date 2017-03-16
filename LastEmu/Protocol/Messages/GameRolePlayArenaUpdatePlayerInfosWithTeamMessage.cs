using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameRolePlayArenaUpdatePlayerInfosWithTeamMessage : GameRolePlayArenaUpdatePlayerInfosMessage
	{
		public const uint Id = 6640;

		public ArenaRankInfos team;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6640;
			}
		}

		public GameRolePlayArenaUpdatePlayerInfosWithTeamMessage()
		{
		}

		public GameRolePlayArenaUpdatePlayerInfosWithTeamMessage(ArenaRankInfos solo, ArenaRankInfos team) : base(solo)
		{
			this.team = team;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.team = new ArenaRankInfos();
			this.team.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.team.Serialize(writer);
		}
	}
}