using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HumanOptionGuild : HumanOption
	{
		public const short Id = 409;

		public GuildInformations guildInformations;

		public override short TypeId
		{
			get
			{
				return 409;
			}
		}

		public HumanOptionGuild()
		{
		}

		public HumanOptionGuild(GuildInformations guildInformations)
		{
			this.guildInformations = guildInformations;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.guildInformations = new GuildInformations();
			this.guildInformations.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.guildInformations.Serialize(writer);
		}
	}
}