using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class InteractiveElementWithAgeBonus : InteractiveElement
	{
		public const short Id = 398;

		public short ageBonus;

		public override short TypeId
		{
			get
			{
				return 398;
			}
		}

		public InteractiveElementWithAgeBonus()
		{
		}

		public InteractiveElementWithAgeBonus(int elementId, int elementTypeId, InteractiveElementSkill[] enabledSkills, InteractiveElementSkill[] disabledSkills, bool onCurrentMap, short ageBonus) : base(elementId, elementTypeId, enabledSkills, disabledSkills, onCurrentMap)
		{
			this.ageBonus = ageBonus;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.ageBonus = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.ageBonus);
		}
	}
}