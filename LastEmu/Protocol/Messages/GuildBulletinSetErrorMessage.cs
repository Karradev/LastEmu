using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GuildBulletinSetErrorMessage : SocialNoticeSetErrorMessage
	{
		public const uint Id = 6691;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6691;
			}
		}

		public GuildBulletinSetErrorMessage()
		{
		}

		public GuildBulletinSetErrorMessage(sbyte reason) : base(reason)
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