using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TrustCertificate
	{
		public const short Id = 377;

		public int id;

		public string hash;

		public virtual short TypeId
		{
			get
			{
				return 377;
			}
		}

		public TrustCertificate()
		{
		}

		public TrustCertificate(int id, string hash)
		{
			this.id = id;
			this.hash = hash;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadInt();
			this.hash = reader.ReadUTF();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.id);
			writer.WriteUTF(this.hash);
		}
	}
}