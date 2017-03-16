using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GuildInAllianceInformations : GuildInformations
	{
		public const short Id = 420;

		public byte nbMembers;

		public override short TypeId
		{
			get
			{
				return 420;
			}
		}

		public GuildInAllianceInformations()
		{
		}

		public GuildInAllianceInformations(uint guildId, string guildName, byte guildLevel, GuildEmblem guildEmblem, byte nbMembers) : base(guildId, guildName, guildLevel, guildEmblem)
		{
			this.nbMembers = nbMembers;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.nbMembers = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(this.nbMembers);
		}
	}
}