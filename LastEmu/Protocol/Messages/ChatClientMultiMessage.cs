using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ChatClientMultiMessage : ChatAbstractClientMessage
	{
		public const uint Id = 861;

		public sbyte channel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)861;
			}
		}

		public ChatClientMultiMessage()
		{
		}

		public ChatClientMultiMessage(string content, sbyte channel) : base(content)
		{
			this.channel = channel;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.channel = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.channel);
		}
	}
}