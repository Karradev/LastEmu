using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class QuestActiveInformations
	{
		public const short Id = 381;

		public uint questId;

		public virtual short TypeId
		{
			get
			{
				return 381;
			}
		}

		public QuestActiveInformations()
		{
		}

		public QuestActiveInformations(uint questId)
		{
			this.questId = questId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.questId = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.questId);
		}
	}
}