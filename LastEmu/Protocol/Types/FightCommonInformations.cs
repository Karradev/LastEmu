using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class FightCommonInformations
	{
		public const short Id = 43;

		public int fightId;

		public sbyte fightType;

		public FightTeamInformations[] fightTeams;

		public uint[] fightTeamsPositions;

		public FightOptionsInformations[] fightTeamsOptions;

		public virtual short TypeId
		{
			get
			{
				return 43;
			}
		}

		public FightCommonInformations()
		{
		}

		public FightCommonInformations(int fightId, sbyte fightType, FightTeamInformations[] fightTeams, uint[] fightTeamsPositions, FightOptionsInformations[] fightTeamsOptions)
		{
			this.fightId = fightId;
			this.fightType = fightType;
			this.fightTeams = fightTeams;
			this.fightTeamsPositions = fightTeamsPositions;
			this.fightTeamsOptions = fightTeamsOptions;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			this.fightType = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.fightTeams = new FightTeamInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.fightTeams[i] = ProtocolTypeManager.GetInstance<FightTeamInformations>(reader.ReadUShort());
				this.fightTeams[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.fightTeamsPositions = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.fightTeamsPositions[j] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.fightTeamsOptions = new FightOptionsInformations[num];
			for (int k = 0; k < num; k++)
			{
				this.fightTeamsOptions[k] = new FightOptionsInformations();
				this.fightTeamsOptions[k].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			writer.WriteSByte(this.fightType);
			writer.WriteShort((short)((int)this.fightTeams.Length));
			FightTeamInformations[] fightTeamInformationsArray = this.fightTeams;
			for (int i = 0; i < (int)fightTeamInformationsArray.Length; i++)
			{
				FightTeamInformations fightTeamInformation = fightTeamInformationsArray[i];
				writer.WriteShort(fightTeamInformation.TypeId);
				fightTeamInformation.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.fightTeamsPositions.Length));
			uint[] numArray = this.fightTeamsPositions;
			for (int j = 0; j < (int)numArray.Length; j++)
			{
				writer.WriteVarShort((int)numArray[j]);
			}
			writer.WriteShort((short)((int)this.fightTeamsOptions.Length));
			FightOptionsInformations[] fightOptionsInformationsArray = this.fightTeamsOptions;
			for (int k = 0; k < (int)fightOptionsInformationsArray.Length; k++)
			{
				fightOptionsInformationsArray[k].Serialize(writer);
			}
		}
	}
}