using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class StatisticData
	{
		public const short Id = 484;

		public virtual short TypeId
		{
			get
			{
				return 484;
			}
		}

		public StatisticData()
		{
		}

		public virtual void Deserialize(IDataReader reader)
		{
		}

		public virtual void Serialize(IDataWriter writer)
		{
		}
	}
}