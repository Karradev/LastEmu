using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GuildMotdSetErrorMessage : SocialNoticeSetErrorMessage
	{
		public const uint Id = 6591;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6591;
			}
		}

		public GuildMotdSetErrorMessage()
		{
		}

		public GuildMotdSetErrorMessage(sbyte reason) : base(reason)
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