using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AchievementRewardErrorMessage : NetworkMessage
	{
		public const uint Id = 6375;

		public short achievementId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6375;
			}
		}

		public AchievementRewardErrorMessage()
		{
		}

		public AchievementRewardErrorMessage(short achievementId)
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