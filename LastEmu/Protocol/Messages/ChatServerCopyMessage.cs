using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ChatServerCopyMessage : ChatAbstractServerMessage
	{
		public const uint Id = 882;

		public double receiverId;

		public string receiverName;

		public override uint ProtocolId
		{
			get
			{
				return (uint)882;
			}
		}

		public ChatServerCopyMessage()
		{
		}

		public ChatServerCopyMessage(sbyte channel, string content, int timestamp, string fingerprint, double receiverId, string receiverName) : base(channel, content, timestamp, fingerprint)
		{
			this.receiverId = receiverId;
			this.receiverName = receiverName;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.receiverId = reader.ReadVarUhLong();
			this.receiverName = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.receiverId);
			writer.WriteUTF(this.receiverName);
		}
	}
}