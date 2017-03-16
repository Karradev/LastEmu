using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AchievementRewardRequestMessage : NetworkMessage
	{
		public const uint Id = 6377;

		public short achievementId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6377;
			}
		}

		public AchievementRewardRequestMessage()
		{
		}

		public AchievementRewardRequestMessage(short achievementId)
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