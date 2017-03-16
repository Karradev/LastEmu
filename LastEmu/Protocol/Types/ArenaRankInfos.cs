using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ArenaRankInfos
	{
		public const short Id = 499;

		public uint rank;

		public uint bestRank;

		public uint victoryCount;

		public uint fightcount;

		public virtual short TypeId
		{
			get
			{
				return 499;
			}
		}

		public ArenaRankInfos()
		{
		}

		public ArenaRankInfos(uint rank, uint bestRank, uint victoryCount, uint fightcount)
		{
			this.rank = rank;
			this.bestRank = bestRank;
			this.victoryCount = victoryCount;
			this.fightcount = fightcount;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.rank = reader.ReadVarUhShort();
			this.bestRank = reader.ReadVarUhShort();
			this.victoryCount = reader.ReadVarUhShort();
			this.fightcount = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.rank);
			writer.WriteVarShort((int)this.bestRank);
			writer.WriteVarShort((int)this.victoryCount);
			writer.WriteVarShort((int)this.fightcount);
		}
	}
}