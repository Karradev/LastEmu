using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class InteractiveElement
	{
		public const short Id = 80;

		public int elementId;

		public int elementTypeId;

		public InteractiveElementSkill[] enabledSkills;

		public InteractiveElementSkill[] disabledSkills;

		public bool onCurrentMap;

		public virtual short TypeId
		{
			get
			{
				return 80;
			}
		}

		public InteractiveElement()
		{
		}

		public InteractiveElement(int elementId, int elementTypeId, InteractiveElementSkill[] enabledSkills, InteractiveElementSkill[] disabledSkills, bool onCurrentMap)
		{
			this.elementId = elementId;
			this.elementTypeId = elementTypeId;
			this.enabledSkills = enabledSkills;
			this.disabledSkills = disabledSkills;
			this.onCurrentMap = onCurrentMap;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.elementId = reader.ReadInt();
			this.elementTypeId = reader.ReadInt();
			ushort num = reader.ReadUShort();
			this.enabledSkills = new InteractiveElementSkill[num];
			for (int i = 0; i < num; i++)
			{
				this.enabledSkills[i] = ProtocolTypeManager.GetInstance<InteractiveElementSkill>(reader.ReadUShort());
				this.enabledSkills[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.disabledSkills = new InteractiveElementSkill[num];
			for (int j = 0; j < num; j++)
			{
				this.disabledSkills[j] = ProtocolTypeManager.GetInstance<InteractiveElementSkill>(reader.ReadUShort());
				this.disabledSkills[j].Deserialize(reader);
			}
			this.onCurrentMap = reader.ReadBoolean();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.elementId);
			writer.WriteInt(this.elementTypeId);
			writer.WriteShort((short)((int)this.enabledSkills.Length));
			InteractiveElementSkill[] interactiveElementSkillArray = this.enabledSkills;
			for (int i = 0; i < (int)interactiveElementSkillArray.Length; i++)
			{
				InteractiveElementSkill interactiveElementSkill = interactiveElementSkillArray[i];
				writer.WriteShort(interactiveElementSkill.TypeId);
				interactiveElementSkill.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.disabledSkills.Length));
			InteractiveElementSkill[] interactiveElementSkillArray1 = this.disabledSkills;
			for (int j = 0; j < (int)interactiveElementSkillArray1.Length; j++)
			{
				InteractiveElementSkill interactiveElementSkill1 = interactiveElementSkillArray1[j];
				writer.WriteShort(interactiveElementSkill1.TypeId);
				interactiveElementSkill1.Serialize(writer);
			}
			writer.WriteBoolean(this.onCurrentMap);
		}
	}
}