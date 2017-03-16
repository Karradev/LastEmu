using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FriendDeleteResultMessage : NetworkMessage
	{
		public const uint Id = 5601;

		public bool success;

		public string name;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5601;
			}
		}

		public FriendDeleteResultMessage()
		{
		}

		public FriendDeleteResultMessage(bool success, string name)
		{
			this.success = success;
			this.name = name;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.success = reader.ReadBoolean();
			this.name = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.success);
			writer.WriteUTF(this.name);
		}
	}
}