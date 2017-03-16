using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildFightPlayersHelpersJoinMessage : NetworkMessage
	{
		public const uint Id = 5720;

		public int fightId;

		public CharacterMinimalPlusLookInformations playerInfo;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5720;
			}
		}

		public GuildFightPlayersHelpersJoinMessage()
		{
		}

		public GuildFightPlayersHelpersJoinMessage(int fightId, CharacterMinimalPlusLookInformations playerInfo)
		{
			this.fightId = fightId;
			this.playerInfo = playerInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			this.playerInfo = new CharacterMinimalPlusLookInformations();
			this.playerInfo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			this.playerInfo.Serialize(writer);
		}
	}
}