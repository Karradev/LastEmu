using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TaxCollectorComplementaryInformations
	{
		public const short Id = 448;

		public virtual short TypeId
		{
			get
			{
				return 448;
			}
		}

		public TaxCollectorComplementaryInformations()
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