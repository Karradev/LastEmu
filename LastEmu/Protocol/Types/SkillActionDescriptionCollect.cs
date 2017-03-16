using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class SkillActionDescriptionCollect : SkillActionDescriptionTimed
	{
		public const short Id = 99;

		public uint min;

		public uint max;

		public override short TypeId
		{
			get
			{
				return 99;
			}
		}

		public SkillActionDescriptionCollect()
		{
		}

		public SkillActionDescriptionCollect(uint skillId, byte time, uint min, uint max) : base(skillId, time)
		{
			this.min = min;
			this.max = max;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.min = reader.ReadVarUhShort();
			this.max = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.min);
			writer.WriteVarShort((int)this.max);
		}
	}
}