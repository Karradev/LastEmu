using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightResultMutantListEntry : FightResultFighterListEntry
	{
		public const short Id = 216;

		public uint level;

		public override short TypeId
		{
			get
			{
				return 216;
			}
		}

		public FightResultMutantListEntry()
		{
		}

		public FightResultMutantListEntry(uint outcome, sbyte wave, FightLoot rewards, double id, bool alive, uint level) : base(outcome, wave, rewards, id, alive)
		{
			this.level = level;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.level = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.level);
		}
	}
}