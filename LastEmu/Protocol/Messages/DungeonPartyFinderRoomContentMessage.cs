using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class DungeonPartyFinderRoomContentMessage : NetworkMessage
	{
		public const uint Id = 6247;

		public uint dungeonId;

		public DungeonPartyFinderPlayer[] players;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6247;
			}
		}

		public DungeonPartyFinderRoomContentMessage()
		{
		}

		public DungeonPartyFinderRoomContentMessage(uint dungeonId, DungeonPartyFinderPlayer[] players)
		{
			this.dungeonId = dungeonId;
			this.players = players;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dungeonId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.players = new DungeonPartyFinderPlayer[num];
			for (int i = 0; i < num; i++)
			{
				this.players[i] = new DungeonPartyFinderPlayer();
				this.players[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.dungeonId);
			writer.WriteShort((short)((int)this.players.Length));
			DungeonPartyFinderPlayer[] dungeonPartyFinderPlayerArray = this.players;
			for (int i = 0; i < (int)dungeonPartyFinderPlayerArray.Length; i++)
			{
				dungeonPartyFinderPlayerArray[i].Serialize(writer);
			}
		}
	}
}