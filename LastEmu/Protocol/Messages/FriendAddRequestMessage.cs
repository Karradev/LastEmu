using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FriendAddRequestMessage : NetworkMessage
	{
		public const uint Id = 4004;

		public string name;

		public override uint ProtocolId
		{
			get
			{
				return (uint)4004;
			}
		}

		public FriendAddRequestMessage()
		{
		}

		public FriendAddRequestMessage(string name)
		{
			this.name = name;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.name = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.name);
		}
	}
}