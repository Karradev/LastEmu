using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class SkillActionDescriptionTimed : SkillActionDescription
	{
		public const short Id = 103;

		public byte time;

		public override short TypeId
		{
			get
			{
				return 103;
			}
		}

		public SkillActionDescriptionTimed()
		{
		}

		public SkillActionDescriptionTimed(uint skillId, byte time) : base(skillId)
		{
			this.time = time;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.time = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(this.time);
		}
	}
}