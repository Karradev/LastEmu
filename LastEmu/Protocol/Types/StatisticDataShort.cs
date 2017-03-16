using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class StatisticDataShort : StatisticData
	{
		public const short Id = 488;

		public short @value;

		public override short TypeId
		{
			get
			{
				return 488;
			}
		}

		public StatisticDataShort()
		{
		}

		public StatisticDataShort(short value)
		{
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.@value = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.@value);
		}
	}
}