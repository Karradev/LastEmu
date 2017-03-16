using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class MonsterBoosts
	{
		public const short Id = 497;

		public uint id;

		public uint xpBoost;

		public uint dropBoost;

		public virtual short TypeId
		{
			get
			{
				return 497;
			}
		}

		public MonsterBoosts()
		{
		}

		public MonsterBoosts(uint id, uint xpBoost, uint dropBoost)
		{
			this.id = id;
			this.xpBoost = xpBoost;
			this.dropBoost = dropBoost;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhInt();
			this.xpBoost = reader.ReadVarUhShort();
			this.dropBoost = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.id);
			writer.WriteVarShort((int)this.xpBoost);
			writer.WriteVarShort((int)this.dropBoost);
		}
	}
}