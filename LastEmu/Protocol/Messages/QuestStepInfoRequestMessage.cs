using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class QuestStepInfoRequestMessage : NetworkMessage
	{
		public const uint Id = 5622;

		public uint questId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5622;
			}
		}

		public QuestStepInfoRequestMessage()
		{
		}

		public QuestStepInfoRequestMessage(uint questId)
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