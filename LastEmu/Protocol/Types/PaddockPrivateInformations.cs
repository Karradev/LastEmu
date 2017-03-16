using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PaddockPrivateInformations : PaddockAbandonnedInformations
	{
		public const short Id = 131;

		public GuildInformations guildInfo;

		public override short TypeId
		{
			get
			{
				return 131;
			}
		}

		public PaddockPrivateInformations()
		{
		}

		public PaddockPrivateInformations(uint maxOutdoorMount, uint maxItems, uint price, bool locked, int guildId, GuildInformations guildInfo) : base(maxOutdoorMount, maxItems, price, locked, guildId)
		{
			this.guildInfo = guildInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.guildInfo = new GuildInformations();
			this.guildInfo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.guildInfo.Serialize(writer);
		}
	}
}