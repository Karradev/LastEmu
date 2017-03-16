using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class JobDescription
	{
		public const short Id = 101;

		public sbyte jobId;

		public SkillActionDescription[] skills;

		public virtual short TypeId
		{
			get
			{
				return 101;
			}
		}

		public JobDescription()
		{
		}

		public JobDescription(sbyte jobId, SkillActionDescription[] skills)
		{
			this.jobId = jobId;
			this.skills = skills;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.jobId = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.skills = new SkillActionDescription[num];
			for (int i = 0; i < num; i++)
			{
				this.skills[i] = ProtocolTypeManager.GetInstance<SkillActionDescription>(reader.ReadUShort());
				this.skills[i].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.jobId);
			writer.WriteShort((short)((int)this.skills.Length));
			SkillActionDescription[] skillActionDescriptionArray = this.skills;
			for (int i = 0; i < (int)skillActionDescriptionArray.Length; i++)
			{
				SkillActionDescription skillActionDescription = skillActionDescriptionArray[i];
				writer.WriteShort(skillActionDescription.TypeId);
				skillActionDescription.Serialize(writer);
			}
		}
	}
}