using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GuildBulletinMessage : BulletinMessage
	{
		public const uint Id = 6689;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6689;
			}
		}

		public GuildBulletinMessage()
		{
		}

		public GuildBulletinMessage(string content, int timestamp, double memberId, string memberName, int lastNotifiedTimestamp) : base(content, timestamp, memberId, memberName, lastNotifiedTimestamp)
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