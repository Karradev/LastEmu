using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class QuestValidatedMessage : NetworkMessage
	{
		public const uint Id = 6097;

		public uint questId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6097;
			}
		}

		public QuestValidatedMessage()
		{
		}

		public QuestValidatedMessage(uint questId)
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