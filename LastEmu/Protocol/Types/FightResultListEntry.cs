using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightResultListEntry
	{
		public const short Id = 16;

		public uint outcome;

		public sbyte wave;

		public FightLoot rewards;

		public virtual short TypeId
		{
			get
			{
				return 16;
			}
		}

		public FightResultListEntry()
		{
		}

		public FightResultListEntry(uint outcome, sbyte wave, FightLoot rewards)
		{
			this.outcome = outcome;
			this.wave = wave;
			this.rewards = rewards;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.outcome = reader.ReadVarUhShort();
			this.wave = reader.ReadSByte();
			this.rewards = new FightLoot();
			this.rewards.Deserialize(reader);
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.outcome);
			writer.WriteSByte(this.wave);
			this.rewards.Serialize(writer);
		}
	}
}