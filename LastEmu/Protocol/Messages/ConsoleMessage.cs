using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ConsoleMessage : NetworkMessage
	{
		public const uint Id = 75;

		public sbyte type;

		public string content;

		public override uint ProtocolId
		{
			get
			{
				return (uint)75;
			}
		}

		public ConsoleMessage()
		{
		}

		public ConsoleMessage(sbyte type, string content)
		{
			this.type = type;
			this.content = content;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.type = reader.ReadSByte();
			this.content = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.type);
			writer.WriteUTF(this.content);
		}
	}
}