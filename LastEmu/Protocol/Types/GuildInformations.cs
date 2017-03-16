using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GuildInformations : BasicGuildInformations
	{
		public const short Id = 127;

		public GuildEmblem guildEmblem;

		public override short TypeId
		{
			get
			{
				return 127;
			}
		}

		public GuildInformations()
		{
		}

		public GuildInformations(uint guildId, string guildName, byte guildLevel, GuildEmblem guildEmblem) : base(guildId, guildName, guildLevel)
		{
			this.guildEmblem = guildEmblem;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.guildEmblem = new GuildEmblem();
			this.guildEmblem.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.guildEmblem.Serialize(writer);
		}
	}
}