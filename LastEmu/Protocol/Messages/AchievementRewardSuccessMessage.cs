using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AchievementRewardSuccessMessage : NetworkMessage
	{
		public const uint Id = 6376;

		public short achievementId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6376;
			}
		}

		public AchievementRewardSuccessMessage()
		{
		}

		public AchievementRewardSuccessMessage(short achievementId)
		{
			this.achievementId = achievementId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.achievementId = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.achievementId);
		}
	}
}