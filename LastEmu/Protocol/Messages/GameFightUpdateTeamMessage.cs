using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameFightUpdateTeamMessage : NetworkMessage
	{
		public const uint Id = 5572;

		public short fightId;

		public FightTeamInformations team;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5572;
			}
		}

		public GameFightUpdateTeamMessage()
		{
		}

		public GameFightUpdateTeamMessage(short fightId, FightTeamInformations team)
		{
			this.fightId = fightId;
			this.team = team;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadShort();
			this.team = new FightTeamInformations();
			this.team.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.fightId);
			this.team.Serialize(writer);
		}
	}
}