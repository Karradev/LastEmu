using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TaxCollectorGuildInformations : TaxCollectorComplementaryInformations
	{
		public const short Id = 446;

		public BasicGuildInformations guild;

		public override short TypeId
		{
			get
			{
				return 446;
			}
		}

		public TaxCollectorGuildInformations()
		{
		}

		public TaxCollectorGuildInformations(BasicGuildInformations guild)
		{
			this.guild = guild;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.guild = new BasicGuildInformations();
			this.guild.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.guild.Serialize(writer);
		}
	}
}