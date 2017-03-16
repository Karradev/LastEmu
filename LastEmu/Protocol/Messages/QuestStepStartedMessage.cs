using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class QuestStepStartedMessage : NetworkMessage
	{
		public const uint Id = 6096;

		public uint questId;

		public uint stepId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6096;
			}
		}

		public QuestStepStartedMessage()
		{
		}

		public QuestStepStartedMessage(uint questId, uint stepId)
		{
			this.questId = questId;
			this.stepId = stepId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.questId = reader.ReadVarUhShort();
			this.stepId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.questId);
			writer.WriteVarShort((int)this.stepId);
		}
	}
}