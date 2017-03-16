using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AchievementDetailsMessage : NetworkMessage
	{
		public const uint Id = 6378;

		public Achievement achievement;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6378;
			}
		}

		public AchievementDetailsMessage()
		{
		}

		public AchievementDetailsMessage(Achievement achievement)
		{
			this.achievement = achievement;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.achievement = new Achievement();
			this.achievement.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.achievement.Serialize(writer);
		}
	}
}