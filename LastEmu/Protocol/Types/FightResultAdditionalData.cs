using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightResultAdditionalData
	{
		public const short Id = 191;

		public virtual short TypeId
		{
			get
			{
				return 191;
			}
		}

		public FightResultAdditionalData()
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