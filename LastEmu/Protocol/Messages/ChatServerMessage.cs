using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ChatServerMessage : ChatAbstractServerMessage
	{
		public const uint Id = 881;

		public double senderId;

		public string senderName;

		public int senderAccountId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)881;
			}
		}

		public ChatServerMessage()
		{
		}

		public ChatServerMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, int senderAccountId) : base(channel, content, timestamp, fingerprint)
		{
			this.senderId = senderId;
			this.senderName = senderName;
			this.senderAccountId = senderAccountId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.senderId = reader.ReadDouble();
			this.senderName = reader.ReadUTF();
			this.senderAccountId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.senderId);
			writer.WriteUTF(this.senderName);
			writer.WriteInt(this.senderAccountId);
		}
	}
}