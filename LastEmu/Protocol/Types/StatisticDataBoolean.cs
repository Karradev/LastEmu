using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class StatisticDataBoolean : StatisticData
	{
		public const short Id = 482;

		public bool @value;

		public override short TypeId
		{
			get
			{
				return 482;
			}
		}

		public StatisticDataBoolean()
		{
		}

		public StatisticDataBoolean(bool value)
		{
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.@value = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(this.@value);
		}
	}
}