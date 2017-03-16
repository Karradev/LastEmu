using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class BulletinMessage : SocialNoticeMessage
	{
		public const uint Id = 6695;

		public int lastNotifiedTimestamp;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6695;
			}
		}

		public BulletinMessage()
		{
		}

		public BulletinMessage(string content, int timestamp, double memberId, string memberName, int lastNotifiedTimestamp) : base(content, timestamp, memberId, memberName)
		{
			this.lastNotifiedTimestamp = lastNotifiedTimestamp;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.lastNotifiedTimestamp = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.lastNotifiedTimestamp);
		}
	}
}