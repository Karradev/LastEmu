using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class FightResultExperienceData : FightResultAdditionalData
	{
		public const short Id = 192;

		public bool showExperience;

		public bool showExperienceLevelFloor;

		public bool showExperienceNextLevelFloor;

		public bool showExperienceFightDelta;

		public bool showExperienceForGuild;

		public bool showExperienceForMount;

		public bool isIncarnationExperience;

		public double experience;

		public double experienceLevelFloor;

		public double experienceNextLevelFloor;

		public double experienceFightDelta;

		public double experienceForGuild;

		public double experienceForMount;

		public sbyte rerollExperienceMul;

		public override short TypeId
		{
			get
			{
				return 192;
			}
		}

		public FightResultExperienceData()
		{
		}

		public FightResultExperienceData(bool showExperience, bool showExperienceLevelFloor, bool showExperienceNextLevelFloor, bool showExperienceFightDelta, bool showExperienceForGuild, bool showExperienceForMount, bool isIncarnationExperience, double experience, double experienceLevelFloor, double experienceNextLevelFloor, double experienceFightDelta, double experienceForGuild, double experienceForMount, sbyte rerollExperienceMul)
		{
			this.showExperience = showExperience;
			this.showExperienceLevelFloor = showExperienceLevelFloor;
			this.showExperienceNextLevelFloor = showExperienceNextLevelFloor;
			this.showExperienceFightDelta = showExperienceFightDelta;
			this.showExperienceForGuild = showExperienceForGuild;
			this.showExperienceForMount = showExperienceForMount;
			this.isIncarnationExperience = isIncarnationExperience;
			this.experience = experience;
			this.experienceLevelFloor = experienceLevelFloor;
			this.experienceNextLevelFloor = experienceNextLevelFloor;
			this.experienceFightDelta = experienceFightDelta;
			this.experienceForGuild = experienceForGuild;
			this.experienceForMount = experienceForMount;
			this.rerollExperienceMul = rerollExperienceMul;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			byte num = reader.ReadByte();
			this.showExperience = BooleanByteWrapper.GetFlag(num, 0);
			this.showExperienceLevelFloor = BooleanByteWrapper.GetFlag(num, 1);
			this.showExperienceNextLevelFloor = BooleanByteWrapper.GetFlag(num, 2);
			this.showExperienceFightDelta = BooleanByteWrapper.GetFlag(num, 3);
			this.showExperienceForGuild = BooleanByteWrapper.GetFlag(num, 4);
			this.showExperienceForMount = BooleanByteWrapper.GetFlag(num, 5);
			this.isIncarnationExperience = BooleanByteWrapper.GetFlag(num, 6);
			this.experience = reader.ReadVarUhLong();
			this.experienceLevelFloor = reader.ReadVarUhLong();
			this.experienceNextLevelFloor = reader.ReadVarUhLong();
			this.experienceFightDelta = reader.ReadVarUhLong();
			this.experienceForGuild = reader.ReadVarUhLong();
			this.experienceForMount = reader.ReadVarUhLong();
			this.rerollExperienceMul = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.showExperience);
			num = BooleanByteWrapper.SetFlag(num, 1, this.showExperienceLevelFloor);
			num = BooleanByteWrapper.SetFlag(num, 2, this.showExperienceNextLevelFloor);
			num = BooleanByteWrapper.SetFlag(num, 3, this.showExperienceFightDelta);
			num = BooleanByteWrapper.SetFlag(num, 4, this.showExperienceForGuild);
			num = BooleanByteWrapper.SetFlag(num, 5, this.showExperienceForMount);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 6, this.isIncarnationExperience));
			writer.WriteVarLong(this.experience);
			writer.WriteVarLong(this.experienceLevelFloor);
			writer.WriteVarLong(this.experienceNextLevelFloor);
			writer.WriteVarLong(this.experienceFightDelta);
			writer.WriteVarLong(this.experienceForGuild);
			writer.WriteVarLong(this.experienceForMount);
			writer.WriteSByte(this.rerollExperienceMul);
		}
	}
}