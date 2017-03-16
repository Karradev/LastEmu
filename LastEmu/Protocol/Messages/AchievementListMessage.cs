using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AchievementListMessage : NetworkMessage
	{
		public const uint Id = 6205;

		public uint[] finishedAchievementsIds;

		public AchievementRewardable[] rewardableAchievements;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6205;
			}
		}

		public AchievementListMessage()
		{
		}

		public AchievementListMessage(uint[] finishedAchievementsIds, AchievementRewardable[] rewardableAchievements)
		{
			this.finishedAchievementsIds = finishedAchievementsIds;
			this.rewardableAchievements = rewardableAchievements;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.finishedAchievementsIds = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.finishedAchievementsIds[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.rewardableAchievements = new AchievementRewardable[num];
			for (int j = 0; j < num; j++)
			{
				this.rewardableAchievements[j] = new AchievementRewardable();
				this.rewardableAchievements[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.finishedAchievementsIds.Length));
			uint[] numArray = this.finishedAchievementsIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.rewardableAchievements.Length));
			AchievementRewardable[] achievementRewardableArray = this.rewardableAchievements;
			for (int j = 0; j < (int)achievementRewardableArray.Length; j++)
			{
				achievementRewardableArray[j].Serialize(writer);
			}
		}
	}
}