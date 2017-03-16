using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameFightEndMessage : NetworkMessage
	{
		public const uint Id = 720;

		public int duration;

		public short ageBonus;

		public short lootShareLimitMalus;

		public FightResultListEntry[] results;

		public NamedPartyTeamWithOutcome[] namedPartyTeamsOutcomes;

		public override uint ProtocolId
		{
			get
			{
				return (uint)720;
			}
		}

		public GameFightEndMessage()
		{
		}

		public GameFightEndMessage(int duration, short ageBonus, short lootShareLimitMalus, FightResultListEntry[] results, NamedPartyTeamWithOutcome[] namedPartyTeamsOutcomes)
		{
			this.duration = duration;
			this.ageBonus = ageBonus;
			this.lootShareLimitMalus = lootShareLimitMalus;
			this.results = results;
			this.namedPartyTeamsOutcomes = namedPartyTeamsOutcomes;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.duration = reader.ReadInt();
			this.ageBonus = reader.ReadShort();
			this.lootShareLimitMalus = reader.ReadShort();
			ushort num = reader.ReadUShort();
			this.results = new FightResultListEntry[num];
			for (int i = 0; i < num; i++)
			{
				this.results[i] = ProtocolTypeManager.GetInstance<FightResultListEntry>(reader.ReadUShort());
				this.results[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.namedPartyTeamsOutcomes = new NamedPartyTeamWithOutcome[num];
			for (int j = 0; j < num; j++)
			{
				this.namedPartyTeamsOutcomes[j] = new NamedPartyTeamWithOutcome();
				this.namedPartyTeamsOutcomes[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.duration);
			writer.WriteShort(this.ageBonus);
			writer.WriteShort(this.lootShareLimitMalus);
			writer.WriteShort((short)((int)this.results.Length));
			FightResultListEntry[] fightResultListEntryArray = this.results;
			for (int i = 0; i < (int)fightResultListEntryArray.Length; i++)
			{
				FightResultListEntry fightResultListEntry = fightResultListEntryArray[i];
				writer.WriteShort(fightResultListEntry.TypeId);
				fightResultListEntry.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.namedPartyTeamsOutcomes.Length));
			NamedPartyTeamWithOutcome[] namedPartyTeamWithOutcomeArray = this.namedPartyTeamsOutcomes;
			for (int j = 0; j < (int)namedPartyTeamWithOutcomeArray.Length; j++)
			{
				namedPartyTeamWithOutcomeArray[j].Serialize(writer);
			}
		}
	}
}