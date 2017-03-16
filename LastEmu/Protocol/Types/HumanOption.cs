using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HumanOption
	{
		public const short Id = 406;

		public virtual short TypeId
		{
			get
			{
				return 406;
			}
		}

		public HumanOption()
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