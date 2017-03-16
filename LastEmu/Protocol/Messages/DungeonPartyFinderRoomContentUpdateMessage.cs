using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class DungeonPartyFinderRoomContentUpdateMessage : NetworkMessage
	{
		public const uint Id = 6250;

		public uint dungeonId;

		public DungeonPartyFinderPlayer[] addedPlayers;

		public double[] removedPlayersIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6250;
			}
		}

		public DungeonPartyFinderRoomContentUpdateMessage()
		{
		}

		public DungeonPartyFinderRoomContentUpdateMessage(uint dungeonId, DungeonPartyFinderPlayer[] addedPlayers, double[] removedPlayersIds)
		{
			this.dungeonId = dungeonId;
			this.addedPlayers = addedPlayers;
			this.removedPlayersIds = removedPlayersIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dungeonId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.addedPlayers = new DungeonPartyFinderPlayer[num];
			for (int i = 0; i < num; i++)
			{
				this.addedPlayers[i] = new DungeonPartyFinderPlayer();
				this.addedPlayers[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.removedPlayersIds = new double[num];
			for (int j = 0; j < num; j++)
			{
				this.removedPlayersIds[j] = reader.ReadVarUhLong();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.dungeonId);
			writer.WriteShort((short)((int)this.addedPlayers.Length));
			DungeonPartyFinderPlayer[] dungeonPartyFinderPlayerArray = this.addedPlayers;
			for (int i = 0; i < (int)dungeonPartyFinderPlayerArray.Length; i++)
			{
				dungeonPartyFinderPlayerArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.removedPlayersIds.Length));
			double[] numArray = this.removedPlayersIds;
			for (int j = 0; j < (int)numArray.Length; j++)
			{
				writer.WriteVarLong(numArray[j]);
			}
		}
	}
}