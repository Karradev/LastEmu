using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildFightPlayersEnemyRemoveMessage : NetworkMessage
	{
		public const uint Id = 5929;

		public int fightId;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5929;
			}
		}

		public GuildFightPlayersEnemyRemoveMessage()
		{
		}

		public GuildFightPlayersEnemyRemoveMessage(int fightId, double playerId)
		{
			this.fightId = fightId;
			this.playerId = playerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			this.playerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			writer.WriteVarLong(this.playerId);
		}
	}
}