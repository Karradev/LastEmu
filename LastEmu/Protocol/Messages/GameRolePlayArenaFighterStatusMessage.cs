using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayArenaFighterStatusMessage : NetworkMessage
	{
		public const uint Id = 6281;

		public int fightId;

		public int playerId;

		public bool accepted;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6281;
			}
		}

		public GameRolePlayArenaFighterStatusMessage()
		{
		}

		public GameRolePlayArenaFighterStatusMessage(int fightId, int playerId, bool accepted)
		{
			this.fightId = fightId;
			this.playerId = playerId;
			this.accepted = accepted;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			this.playerId = reader.ReadInt();
			this.accepted = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			writer.WriteInt(this.playerId);
			writer.WriteBoolean(this.accepted);
		}
	}
}