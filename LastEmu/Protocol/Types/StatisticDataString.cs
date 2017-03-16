using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class StatisticDataString : StatisticData
	{
		public const short Id = 487;

		public string @value;

		public override short TypeId
		{
			get
			{
				return 487;
			}
		}

		public StatisticDataString()
		{
		}

		public StatisticDataString(string value)
		{
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.@value = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.@value);
		}
	}
}