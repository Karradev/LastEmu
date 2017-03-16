using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AbstractSocialGroupInfos
	{
		public const short Id = 416;

		public virtual short TypeId
		{
			get
			{
				return 416;
			}
		}

		public AbstractSocialGroupInfos()
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