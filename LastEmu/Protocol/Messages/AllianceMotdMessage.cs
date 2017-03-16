using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class AllianceMotdMessage : SocialNoticeMessage
	{
		public const uint Id = 6685;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6685;
			}
		}

		public AllianceMotdMessage()
		{
		}

		public AllianceMotdMessage(string content, int timestamp, double memberId, string memberName) : base(content, timestamp, memberId, memberName)
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