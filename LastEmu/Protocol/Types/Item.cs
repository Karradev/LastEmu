using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class Item
	{
		public const short Id = 7;

		public virtual short TypeId
		{
			get
			{
				return 7;
			}
		}

		public Item()
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