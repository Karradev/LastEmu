using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AdditionalTaxCollectorInformations
	{
		public const short Id = 165;

		public string collectorCallerName;

		public int date;

		public virtual short TypeId
		{
			get
			{
				return 165;
			}
		}

		public AdditionalTaxCollectorInformations()
		{
		}

		public AdditionalTaxCollectorInformations(string collectorCallerName, int date)
		{
			this.collectorCallerName = collectorCallerName;
			this.date = date;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.collectorCallerName = reader.ReadUTF();
			this.date = reader.ReadInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.collectorCallerName);
			writer.WriteInt(this.date);
		}
	}
}