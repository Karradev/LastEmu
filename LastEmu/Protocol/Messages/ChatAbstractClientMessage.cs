using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChatAbstractClientMessage : NetworkMessage
	{
		public const uint Id = 850;

		public string content;

		public override uint ProtocolId
		{
			get
			{
				return (uint)850;
			}
		}

		public ChatAbstractClientMessage()
		{
		}

		public ChatAbstractClientMessage(string content)
		{
			this.content = content;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.content = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.content);
		}
	}
}