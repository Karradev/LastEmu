using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class QuestObjectiveInformationsWithCompletion : QuestObjectiveInformations
	{
		public const short Id = 386;

		public uint curCompletion;

		public uint maxCompletion;

		public override short TypeId
		{
			get
			{
				return 386;
			}
		}

		public QuestObjectiveInformationsWithCompletion()
		{
		}

		public QuestObjectiveInformationsWithCompletion(uint objectiveId, bool objectiveStatus, string[] dialogParams, uint curCompletion, uint maxCompletion) : base(objectiveId, objectiveStatus, dialogParams)
		{
			this.curCompletion = curCompletion;
			this.maxCompletion = maxCompletion;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.curCompletion = reader.ReadVarUhShort();
			this.maxCompletion = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.curCompletion);
			writer.WriteVarShort((int)this.maxCompletion);
		}
	}
}