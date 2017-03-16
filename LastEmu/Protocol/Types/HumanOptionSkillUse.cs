using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HumanOptionSkillUse : HumanOption
	{
		public const short Id = 495;

		public uint elementId;

		public uint skillId;

		public double skillEndTime;

		public override short TypeId
		{
			get
			{
				return 495;
			}
		}

		public HumanOptionSkillUse()
		{
		}

		public HumanOptionSkillUse(uint elementId, uint skillId, double skillEndTime)
		{
			this.elementId = elementId;
			this.skillId = skillId;
			this.skillEndTime = skillEndTime;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.elementId = reader.ReadVarUhInt();
			this.skillId = reader.ReadVarUhShort();
			this.skillEndTime = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.elementId);
			writer.WriteVarShort((int)this.skillId);
			writer.WriteDouble(this.skillEndTime);
		}
	}
}