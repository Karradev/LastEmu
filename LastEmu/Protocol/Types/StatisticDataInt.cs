using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class StatisticDataInt : StatisticData
	{
		public const short Id = 485;

		public int @value;

		public override short TypeId
		{
			get
			{
				return 485;
			}
		}

		public StatisticDataInt()
		{
		}

		public StatisticDataInt(int value)
		{
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.@value = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.@value);
		}
	}
}