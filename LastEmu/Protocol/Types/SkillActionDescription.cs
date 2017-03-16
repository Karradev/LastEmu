using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class SkillActionDescription
	{
		public const short Id = 102;

		public uint skillId;

		public virtual short TypeId
		{
			get
			{
				return 102;
			}
		}

		public SkillActionDescription()
		{
		}

		public SkillActionDescription(uint skillId)
		{
			this.skillId = skillId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.skillId = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.skillId);
		}
	}
}