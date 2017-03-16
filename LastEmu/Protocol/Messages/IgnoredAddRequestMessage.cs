using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IgnoredAddRequestMessage : NetworkMessage
	{
		public const uint Id = 5673;

		public string name;

		public bool session;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5673;
			}
		}

		public IgnoredAddRequestMessage()
		{
		}

		public IgnoredAddRequestMessage(string name, bool session)
		{
			this.name = name;
			this.session = session;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.name = reader.ReadUTF();
			this.session = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.name);
			writer.WriteBoolean(this.session);
		}
	}
}