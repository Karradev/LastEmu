using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class QuestStartedMessage : NetworkMessage
	{
		public const uint Id = 6091;

		public uint questId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6091;
			}
		}

		public QuestStartedMessage()
		{
		}

		public QuestStartedMessage(uint questId)
		{
			this.questId = questId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.questId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.questId);
		}
	}
}