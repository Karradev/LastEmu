using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ChatClientPrivateMessage : ChatAbstractClientMessage
	{
		public const uint Id = 851;

		public string receiver;

		public override uint ProtocolId
		{
			get
			{
				return (uint)851;
			}
		}

		public ChatClientPrivateMessage()
		{
		}

		public ChatClientPrivateMessage(string content, string receiver) : base(content)
		{
			this.receiver = receiver;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.receiver = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.receiver);
		}
	}
}