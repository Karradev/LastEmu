using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class Achievement
	{
		public const short Id = 363;

		public uint id;

		public AchievementObjective[] finishedObjective;

		public AchievementStartedObjective[] startedObjectives;

		public virtual short TypeId
		{
			get
			{
				return 363;
			}
		}

		public Achievement()
		{
		}

		public Achievement(uint id, AchievementObjective[] finishedObjective, AchievementStartedObjective[] startedObjectives)
		{
			this.id = id;
			this.finishedObjective = finishedObjective;
			this.startedObjectives = startedObjectives;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.finishedObjective = new AchievementObjective[num];
			for (int i = 0; i < num; i++)
			{
				this.finishedObjective[i] = new AchievementObjective();
				this.finishedObjective[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.startedObjectives = new AchievementStartedObjective[num];
			for (int j = 0; j < num; j++)
			{
				this.startedObjectives[j] = new AchievementStartedObjective();
				this.startedObjectives[j].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.id);
			writer.WriteShort((short)((int)this.finishedObjective.Length));
			AchievementObjective[] achievementObjectiveArray = this.finishedObjective;
			for (int i = 0; i < (int)achievementObjectiveArray.Length; i++)
			{
				achievementObjectiveArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.startedObjectives.Length));
			AchievementStartedObjective[] achievementStartedObjectiveArray = this.startedObjectives;
			for (int j = 0; j < (int)achievementStartedObjectiveArray.Length; j++)
			{
				achievementStartedObjectiveArray[j].Serialize(writer);
			}
		}
	}
}