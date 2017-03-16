using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GuildMotdMessage : SocialNoticeMessage
	{
		public const uint Id = 6590;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6590;
			}
		}

		public GuildMotdMessage()
		{
		}

		public GuildMotdMessage(string content, int timestamp, double memberId, string memberName) : base(content, timestamp, memberId, memberName)
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