using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildFightPlayersEnemiesListMessage : NetworkMessage
	{
		public const uint Id = 5928;

		public int fightId;

		public CharacterMinimalPlusLookInformations[] playerInfo;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5928;
			}
		}

		public GuildFightPlayersEnemiesListMessage()
		{
		}

		public GuildFightPlayersEnemiesListMessage(int fightId, CharacterMinimalPlusLookInformations[] playerInfo)
		{
			this.fightId = fightId;
			this.playerInfo = playerInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			ushort num = reader.ReadUShort();
			this.playerInfo = new CharacterMinimalPlusLookInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.playerInfo[i] = new CharacterMinimalPlusLookInformations();
				this.playerInfo[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			writer.WriteShort((short)((int)this.playerInfo.Length));
			CharacterMinimalPlusLookInformations[] characterMinimalPlusLookInformationsArray = this.playerInfo;
			for (int i = 0; i < (int)characterMinimalPlusLookInformationsArray.Length; i++)
			{
				characterMinimalPlusLookInformationsArray[i].Serialize(writer);
			}
		}
	}
}