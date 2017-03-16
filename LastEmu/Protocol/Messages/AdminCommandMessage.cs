using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AdminCommandMessage : NetworkMessage
	{
		public const uint Id = 76;

		public string content;

		public override uint ProtocolId
		{
			get
			{
				return (uint)76;
			}
		}

		public AdminCommandMessage()
		{
		}

		public AdminCommandMessage(string content)
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