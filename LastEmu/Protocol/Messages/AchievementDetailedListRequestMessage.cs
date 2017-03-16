using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AchievementDetailedListRequestMessage : NetworkMessage
	{
		public const uint Id = 6357;

		public uint categoryId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6357;
			}
		}

		public AchievementDetailedListRequestMessage()
		{
		}

		public AchievementDetailedListRequestMessage(uint categoryId)
		{
			this.categoryId = categoryId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.categoryId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.categoryId);
		}
	}
}