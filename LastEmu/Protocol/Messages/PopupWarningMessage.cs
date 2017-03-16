using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PopupWarningMessage : NetworkMessage
	{
		public const uint Id = 6134;

		public byte lockDuration;

		public string author;

		public string content;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6134;
			}
		}

		public PopupWarningMessage()
		{
		}

		public PopupWarningMessage(byte lockDuration, string author, string content)
		{
			this.lockDuration = lockDuration;
			this.author = author;
			this.content = content;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.lockDuration = reader.ReadByte();
			this.author = reader.ReadUTF();
			this.content = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteByte(this.lockDuration);
			writer.WriteUTF(this.author);
			writer.WriteUTF(this.content);
		}
	}
}