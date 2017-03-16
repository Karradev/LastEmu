using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class SkillActionDescriptionCraft : SkillActionDescription
	{
		public const short Id = 100;

		public sbyte probability;

		public override short TypeId
		{
			get
			{
				return 100;
			}
		}

		public SkillActionDescriptionCraft()
		{
		}

		public SkillActionDescriptionCraft(uint skillId, sbyte probability) : base(skillId)
		{
			this.probability = probability;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.probability = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.probability);
		}
	}
}