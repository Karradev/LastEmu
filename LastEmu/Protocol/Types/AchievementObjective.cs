using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AchievementObjective
	{
		public const short Id = 404;

		public uint id;

		public uint maxValue;

		public virtual short TypeId
		{
			get
			{
				return 404;
			}
		}

		public AchievementObjective()
		{
		}

		public AchievementObjective(uint id, uint maxValue)
		{
			this.id = id;
			this.maxValue = maxValue;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhInt();
			this.maxValue = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.id);
			writer.WriteVarShort((int)this.maxValue);
		}
	}
}