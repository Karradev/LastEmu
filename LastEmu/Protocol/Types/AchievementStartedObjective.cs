using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AchievementStartedObjective : AchievementObjective
	{
		public const short Id = 402;

		public uint @value;

		public override short TypeId
		{
			get
			{
				return 402;
			}
		}

		public AchievementStartedObjective()
		{
		}

		public AchievementStartedObjective(uint id, uint maxValue, uint value) : base(id, maxValue)
		{
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.@value = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.@value);
		}
	}
}