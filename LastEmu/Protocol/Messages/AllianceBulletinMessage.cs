using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class AllianceBulletinMessage : BulletinMessage
	{
		public const uint Id = 6690;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6690;
			}
		}

		public AllianceBulletinMessage()
		{
		}

		public AllianceBulletinMessage(string content, int timestamp, double memberId, string memberName, int lastNotifiedTimestamp) : base(content, timestamp, memberId, memberName, lastNotifiedTimestamp)
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