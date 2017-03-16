using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class DungeonPartyFinderPlayer
	{
		public const short Id = 373;

		public double playerId;

		public string playerName;

		public sbyte breed;

		public bool sex;

		public byte level;

		public virtual short TypeId
		{
			get
			{
				return 373;
			}
		}

		public DungeonPartyFinderPlayer()
		{
		}

		public DungeonPartyFinderPlayer(double playerId, string playerName, sbyte breed, bool sex, byte level)
		{
			this.playerId = playerId;
			this.playerName = playerName;
			this.breed = breed;
			this.sex = sex;
			this.level = level;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.playerId = reader.ReadVarUhLong();
			this.playerName = reader.ReadUTF();
			this.breed = reader.ReadSByte();
			this.sex = reader.ReadBoolean();
			this.level = reader.ReadByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.playerId);
			writer.WriteUTF(this.playerName);
			writer.WriteSByte(this.breed);
			writer.WriteBoolean(this.sex);
			writer.WriteByte(this.level);
		}
	}
}