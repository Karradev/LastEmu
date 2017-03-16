using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class QuestStartRequestMessage : NetworkMessage
	{
		public const uint Id = 5643;

		public uint questId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5643;
			}
		}

		public QuestStartRequestMessage()
		{
		}

		public QuestStartRequestMessage(uint questId)
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