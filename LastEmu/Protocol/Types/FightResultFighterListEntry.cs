using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightResultFighterListEntry : FightResultListEntry
	{
		public const short Id = 189;

		public double id;

		public bool alive;

		public override short TypeId
		{
			get
			{
				return 189;
			}
		}

		public FightResultFighterListEntry()
		{
		}

		public FightResultFighterListEntry(uint outcome, sbyte wave, FightLoot rewards, double id, bool alive) : base(outcome, wave, rewards)
		{
			this.id = id;
			this.alive = alive;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadDouble();
			this.alive = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.id);
			writer.WriteBoolean(this.alive);
		}
	}
}