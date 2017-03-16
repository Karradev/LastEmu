using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TreasureHuntStep
	{
		public const short Id = 463;

		public virtual short TypeId
		{
			get
			{
				return 463;
			}
		}

		public TreasureHuntStep()
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