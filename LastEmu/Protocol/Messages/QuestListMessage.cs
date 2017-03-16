using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class QuestListMessage : NetworkMessage
	{
		public const uint Id = 5626;

		public uint[] finishedQuestsIds;

		public uint[] finishedQuestsCounts;

		public QuestActiveInformations[] activeQuests;

		public uint[] reinitDoneQuestsIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5626;
			}
		}

		public QuestListMessage()
		{
		}

		public QuestListMessage(uint[] finishedQuestsIds, uint[] finishedQuestsCounts, QuestActiveInformations[] activeQuests, uint[] reinitDoneQuestsIds)
		{
			this.finishedQuestsIds = finishedQuestsIds;
			this.finishedQuestsCounts = finishedQuestsCounts;
			this.activeQuests = activeQuests;
			this.reinitDoneQuestsIds = reinitDoneQuestsIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.finishedQuestsIds = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.finishedQuestsIds[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.finishedQuestsCounts = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.finishedQuestsCounts[j] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.activeQuests = new QuestActiveInformations[num];
			for (int k = 0; k < num; k++)
			{
				this.activeQuests[k] = ProtocolTypeManager.GetInstance<QuestActiveInformations>(reader.ReadUShort());
				this.activeQuests[k].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.reinitDoneQuestsIds = new uint[num];
			for (int l = 0; l < num; l++)
			{
				this.reinitDoneQuestsIds[l] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.finishedQuestsIds.Length));
			uint[] numArray = this.finishedQuestsIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.finishedQuestsCounts.Length));
			uint[] numArray1 = this.finishedQuestsCounts;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarShort((int)numArray1[j]);
			}
			writer.WriteShort((short)((int)this.activeQuests.Length));
			QuestActiveInformations[] questActiveInformationsArray = this.activeQuests;
			for (int k = 0; k < (int)questActiveInformationsArray.Length; k++)
			{
				QuestActiveInformations questActiveInformation = questActiveInformationsArray[k];
				writer.WriteShort(questActiveInformation.TypeId);
				questActiveInformation.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.reinitDoneQuestsIds.Length));
			uint[] numArray2 = this.reinitDoneQuestsIds;
			for (int l = 0; l < (int)numArray2.Length; l++)
			{
				writer.WriteVarShort((int)numArray2[l]);
			}
		}
	}
}