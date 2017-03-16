using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class NamedPartyTeamWithOutcome
	{
		public const short Id = 470;

		public NamedPartyTeam team;

		public uint outcome;

		public virtual short TypeId
		{
			get
			{
				return 470;
			}
		}

		public NamedPartyTeamWithOutcome()
		{
		}

		public NamedPartyTeamWithOutcome(NamedPartyTeam team, uint outcome)
		{
			this.team = team;
			this.outcome = outcome;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.team = new NamedPartyTeam();
			this.team.Deserialize(reader);
			this.outcome = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			this.team.Serialize(writer);
			writer.WriteVarShort((int)this.outcome);
		}
	}
}