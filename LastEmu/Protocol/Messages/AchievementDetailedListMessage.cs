using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AchievementDetailedListMessage : NetworkMessage
	{
		public const uint Id = 6358;

		public Achievement[] startedAchievements;

		public Achievement[] finishedAchievements;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6358;
			}
		}

		public AchievementDetailedListMessage()
		{
		}

		public AchievementDetailedListMessage(Achievement[] startedAchievements, Achievement[] finishedAchievements)
		{
			this.startedAchievements = startedAchievements;
			this.finishedAchievements = finishedAchievements;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.startedAchievements = new Achievement[num];
			for (int i = 0; i < num; i++)
			{
				this.startedAchievements[i] = new Achievement();
				this.startedAchievements[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.finishedAchievements = new Achievement[num];
			for (int j = 0; j < num; j++)
			{
				this.finishedAchievements[j] = new Achievement();
				this.finishedAchievements[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.startedAchievements.Length));
			Achievement[] achievementArray = this.startedAchievements;
			for (int i = 0; i < (int)achievementArray.Length; i++)
			{
				achievementArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.finishedAchievements.Length));
			Achievement[] achievementArray1 = this.finishedAchievements;
			for (int j = 0; j < (int)achievementArray1.Length; j++)
			{
				achievementArray1[j].Serialize(writer);
			}
		}
	}
}