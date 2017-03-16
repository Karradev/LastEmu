using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameRolePlayArenaUpdatePlayerInfosMessage : NetworkMessage
	{
		public const uint Id = 6301;

		public ArenaRankInfos solo;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6301;
			}
		}

		public GameRolePlayArenaUpdatePlayerInfosMessage()
		{
		}

		public GameRolePlayArenaUpdatePlayerInfosMessage(ArenaRankInfos solo)
		{
			this.solo = solo;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.solo = new ArenaRankInfos();
			this.solo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.solo.Serialize(writer);
		}
	}
}