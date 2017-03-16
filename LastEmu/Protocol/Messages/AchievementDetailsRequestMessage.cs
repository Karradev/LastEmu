using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AchievementDetailsRequestMessage : NetworkMessage
	{
		public const uint Id = 6380;

		public uint achievementId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6380;
			}
		}

		public AchievementDetailsRequestMessage()
		{
		}

		public AchievementDetailsRequestMessage(uint achievementId)
		{
			this.achievementId = achievementId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.achievementId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.achievementId);
		}
	}
}