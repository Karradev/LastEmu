using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AbstractContactInformations
	{
		public const short Id = 380;

		public int accountId;

		public string accountName;

		public virtual short TypeId
		{
			get
			{
				return 380;
			}
		}

		public AbstractContactInformations()
		{
		}

		public AbstractContactInformations(int accountId, string accountName)
		{
			this.accountId = accountId;
			this.accountName = accountName;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.accountId = reader.ReadInt();
			this.accountName = reader.ReadUTF();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.accountId);
			writer.WriteUTF(this.accountName);
		}
	}
}