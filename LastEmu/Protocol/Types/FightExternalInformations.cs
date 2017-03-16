using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightExternalInformations
	{
		public const short Id = 117;

		public int fightId;

		public sbyte fightType;

		public int fightStart;

		public bool fightSpectatorLocked;

		public FightTeamLightInformations[] fightTeams;

		public FightOptionsInformations[] fightTeamsOptions;

		public virtual short TypeId
		{
			get
			{
				return 117;
			}
		}

		public FightExternalInformations()
		{
		}

		public FightExternalInformations(int fightId, sbyte fightType, int fightStart, bool fightSpectatorLocked, FightTeamLightInformations[] fightTeams, FightOptionsInformations[] fightTeamsOptions)
		{
			this.fightId = fightId;
			this.fightType = fightType;
			this.fightStart = fightStart;
			this.fightSpectatorLocked = fightSpectatorLocked;
			this.fightTeams = fightTeams;
			this.fightTeamsOptions = fightTeamsOptions;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			this.fightType = reader.ReadSByte();
			this.fightStart = reader.ReadInt();
			this.fightSpectatorLocked = reader.ReadBoolean();
			ushort num = reader.ReadUShort();
			this.fightTeams = new FightTeamLightInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.fightTeams[i] = new FightTeamLightInformations();
				this.fightTeams[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.fightTeamsOptions = new FightOptionsInformations[num];
			for (int j = 0; j < num; j++)
			{
				this.fightTeamsOptions[j] = new FightOptionsInformations();
				this.fightTeamsOptions[j].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			writer.WriteSByte(this.fightType);
			writer.WriteInt(this.fightStart);
			writer.WriteBoolean(this.fightSpectatorLocked);
			writer.WriteShort((short)((int)this.fightTeams.Length));
			FightTeamLightInformations[] fightTeamLightInformationsArray = this.fightTeams;
			for (int i = 0; i < (int)fightTeamLightInformationsArray.Length; i++)
			{
				fightTeamLightInformationsArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.fightTeamsOptions.Length));
			FightOptionsInformations[] fightOptionsInformationsArray = this.fightTeamsOptions;
			for (int j = 0; j < (int)fightOptionsInformationsArray.Length; j++)
			{
				fightOptionsInformationsArray[j].Serialize(writer);
			}
		}
	}
}