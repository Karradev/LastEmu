using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class StatisticDataByte : StatisticData
	{
		public const short Id = 486;

		public sbyte @value;

		public override short TypeId
		{
			get
			{
				return 486;
			}
		}

		public StatisticDataByte()
		{
		}

		public StatisticDataByte(sbyte value)
		{
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.@value = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.@value);
		}
	}
}