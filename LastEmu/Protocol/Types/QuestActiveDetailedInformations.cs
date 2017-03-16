using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class QuestActiveDetailedInformations : QuestActiveInformations
	{
		public const short Id = 382;

		public uint stepId;

		public QuestObjectiveInformations[] objectives;

		public override short TypeId
		{
			get
			{
				return 382;
			}
		}

		public QuestActiveDetailedInformations()
		{
		}

		public QuestActiveDetailedInformations(uint questId, uint stepId, QuestObjectiveInformations[] objectives) : base(questId)
		{
			this.stepId = stepId;
			this.objectives = objectives;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.stepId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.objectives = new QuestObjectiveInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.objectives[i] = ProtocolTypeManager.GetInstance<QuestObjectiveInformations>(reader.ReadUShort());
				this.objectives[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.stepId);
			writer.WriteShort((short)((int)this.objectives.Length));
			QuestObjectiveInformations[] questObjectiveInformationsArray = this.objectives;
			for (int i = 0; i < (int)questObjectiveInformationsArray.Length; i++)
			{
				QuestObjectiveInformations questObjectiveInformation = questObjectiveInformationsArray[i];
				writer.WriteShort(questObjectiveInformation.TypeId);
				questObjectiveInformation.Serialize(writer);
			}
		}
	}
}