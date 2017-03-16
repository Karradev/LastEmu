using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChatAbstractServerMessage : NetworkMessage
	{
		public const uint Id = 880;

		public sbyte channel;

		public string content;

		public int timestamp;

		public string fingerprint;

		public override uint ProtocolId
		{
			get
			{
				return (uint)880;
			}
		}

		public ChatAbstractServerMessage()
		{
		}

		public ChatAbstractServerMessage(sbyte channel, string content, int timestamp, string fingerprint)
		{
			this.channel = channel;
			this.content = content;
			this.timestamp = timestamp;
			this.fingerprint = fingerprint;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.channel = reader.ReadSByte();
			this.content = reader.ReadUTF();
			this.timestamp = reader.ReadInt();
			this.fingerprint = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.channel);
			writer.WriteUTF(this.content);
			writer.WriteInt(this.timestamp);
			writer.WriteUTF(this.fingerprint);
		}
	}
}