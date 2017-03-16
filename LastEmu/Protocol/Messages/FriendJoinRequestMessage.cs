using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FriendJoinRequestMessage : NetworkMessage
	{
		public const uint Id = 5605;

		public string name;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5605;
			}
		}

		public FriendJoinRequestMessage()
		{
		}

		public FriendJoinRequestMessage(string name)
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