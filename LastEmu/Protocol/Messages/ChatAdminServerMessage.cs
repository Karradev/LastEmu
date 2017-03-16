using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ChatAdminServerMessage : ChatServerMessage
	{
		public const uint Id = 6135;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6135;
			}
		}

		public ChatAdminServerMessage()
		{
		}

		public ChatAdminServerMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, int senderAccountId) : base(channel, content, timestamp, fingerprint, senderId, senderName, senderAccountId)
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