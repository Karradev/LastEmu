using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class QuestObjectiveValidationMessage : NetworkMessage
	{
		public const uint Id = 6085;

		public uint questId;

		public uint objectiveId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6085;
			}
		}

		public QuestObjectiveValidationMessage()
		{
		}

		public QuestObjectiveValidationMessage(uint questId, uint objectiveId)
		{
			this.questId = questId;
			this.objectiveId = objectiveId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.questId = reader.ReadVarUhShort();
			this.objectiveId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.questId);
			writer.WriteVarShort((int)this.objectiveId);
		}
	}
}