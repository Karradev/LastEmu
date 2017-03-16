using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class IgnoredInformations : AbstractContactInformations
	{
		public const short Id = 106;

		public override short TypeId
		{
			get
			{
				return 106;
			}
		}

		public IgnoredInformations()
		{
		}

		public IgnoredInformations(int accountId, string accountName) : base(accountId, accountName)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}