using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class QuestStepValidatedMessage : NetworkMessage
	{
		public const uint Id = 6099;

		public uint questId;

		public uint stepId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6099;
			}
		}

		public QuestStepValidatedMessage()
		{
		}

		public QuestStepValidatedMessage(uint questId, uint stepId)
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