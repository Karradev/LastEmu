using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AchievementRewardable
	{
		public const short Id = 412;

		public uint id;

		public byte finishedlevel;

		public virtual short TypeId
		{
			get
			{
				return 412;
			}
		}

		public AchievementRewardable()
		{
		}

		public AchievementRewardable(uint id, byte finishedlevel)
		{
			this.id = id;
			this.finishedlevel = finishedlevel;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhShort();
			this.finishedlevel = reader.ReadByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.id);
			writer.WriteByte(this.finishedlevel);
		}
	}
}