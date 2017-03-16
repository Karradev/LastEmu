using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildInformationsMemberUpdateMessage : NetworkMessage
	{
		public const uint Id = 5597;

		public GuildMember member;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5597;
			}
		}

		public GuildInformationsMemberUpdateMessage()
		{
		}

		public GuildInformationsMemberUpdateMessage(GuildMember member)
		{
			this.member = member;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.member = new GuildMember();
			this.member.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.member.Serialize(writer);
		}
	}
}