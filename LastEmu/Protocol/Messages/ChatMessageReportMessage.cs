using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChatMessageReportMessage : NetworkMessage
	{
		public const uint Id = 821;

		public string senderName;

		public string content;

		public int timestamp;

		public sbyte channel;

		public string fingerprint;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)821;
			}
		}

		public ChatMessageReportMessage()
		{
		}

		public ChatMessageReportMessage(string senderName, string content, int timestamp, sbyte channel, string fingerprint, sbyte reason)
		{
			this.senderName = senderName;
			this.content = content;
			this.timestamp = timestamp;
			this.channel = channel;
			this.fingerprint = fingerprint;
			this.reason = reason;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.senderName = reader.ReadUTF();
			this.content = reader.ReadUTF();
			this.timestamp = reader.ReadInt();
			this.channel = reader.ReadSByte();
			this.fingerprint = reader.ReadUTF();
			this.reason = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.senderName);
			writer.WriteUTF(this.content);
			writer.WriteInt(this.timestamp);
			writer.WriteSByte(this.channel);
			writer.WriteUTF(this.fingerprint);
			writer.WriteSByte(this.reason);
		}
	}
}