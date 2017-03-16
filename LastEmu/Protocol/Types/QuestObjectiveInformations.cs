using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class QuestObjectiveInformations
	{
		public const short Id = 385;

		public uint objectiveId;

		public bool objectiveStatus;

		public string[] dialogParams;

		public virtual short TypeId
		{
			get
			{
				return 385;
			}
		}

		public QuestObjectiveInformations()
		{
		}

		public QuestObjectiveInformations(uint objectiveId, bool objectiveStatus, string[] dialogParams)
		{
			this.objectiveId = objectiveId;
			this.objectiveStatus = objectiveStatus;
			this.dialogParams = dialogParams;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.objectiveId = reader.ReadVarUhShort();
			this.objectiveStatus = reader.ReadBoolean();
			ushort num = reader.ReadUShort();
			this.dialogParams = new string[num];
			for (int i = 0; i < num; i++)
			{
				this.dialogParams[i] = reader.ReadUTF();
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.objectiveId);
			writer.WriteBoolean(this.objectiveStatus);
			writer.WriteShort((short)((int)this.dialogParams.Length));
			string[] strArrays = this.dialogParams;
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				writer.WriteUTF(strArrays[i]);
			}
		}
	}
}