using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ClientKeyMessage : NetworkMessage
	{
		public const uint Id = 5607;

		public string key;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5607;
			}
		}

		public ClientKeyMessage()
		{
		}

		public ClientKeyMessage(string key)
		{
			this.key = key;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.key = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.key);
		}
	}
}