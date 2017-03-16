using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SocialNoticeMessage : NetworkMessage
	{
		public const uint Id = 6688;

		public string content;

		public int timestamp;

		public double memberId;

		public string memberName;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6688;
			}
		}

		public SocialNoticeMessage()
		{
		}

		public SocialNoticeMessage(string content, int timestamp, double memberId, string memberName)
		{
			this.content = content;
			this.timestamp = timestamp;
			this.memberId = memberId;
			this.memberName = memberName;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.content = reader.ReadUTF();
			this.timestamp = reader.ReadInt();
			this.memberId = reader.ReadVarUhLong();
			this.memberName = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.content);
			writer.WriteInt(this.timestamp);
			writer.WriteVarLong(this.memberId);
			writer.WriteUTF(this.memberName);
		}
	}
}