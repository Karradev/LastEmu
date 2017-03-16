using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightResultTaxCollectorListEntry : FightResultFighterListEntry
	{
		public const short Id = 84;

		public byte level;

		public BasicGuildInformations guildInfo;

		public int experienceForGuild;

		public override short TypeId
		{
			get
			{
				return 84;
			}
		}

		public FightResultTaxCollectorListEntry()
		{
		}

		public FightResultTaxCollectorListEntry(uint outcome, sbyte wave, FightLoot rewards, double id, bool alive, byte level, BasicGuildInformations guildInfo, int experienceForGuild) : base(outcome, wave, rewards, id, alive)
		{
			this.level = level;
			this.guildInfo = guildInfo;
			this.experienceForGuild = experienceForGuild;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.level = reader.ReadByte();
			this.guildInfo = new BasicGuildInformations();
			this.guildInfo.Deserialize(reader);
			this.experienceForGuild = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(this.level);
			this.guildInfo.Serialize(writer);
			writer.WriteInt(this.experienceForGuild);
		}
	}
}