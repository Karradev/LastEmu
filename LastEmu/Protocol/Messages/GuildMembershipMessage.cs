using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildMembershipMessage : GuildJoinedMessage
	{
		public const uint Id = 5835;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5835;
			}
		}

		public GuildMembershipMessage()
		{
		}

		public GuildMembershipMessage(GuildInformations guildInfo, uint memberRights) : base(guildInfo, memberRights)
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