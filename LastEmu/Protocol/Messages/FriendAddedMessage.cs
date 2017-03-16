using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class FriendAddedMessage : NetworkMessage
	{
		public const uint Id = 5599;

		public FriendInformations friendAdded;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5599;
			}
		}

		public FriendAddedMessage()
		{
		}

		public FriendAddedMessage(FriendInformations friendAdded)
		{
			this.friendAdded = friendAdded;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.friendAdded = ProtocolTypeManager.GetInstance<FriendInformations>(reader.ReadUShort());
			this.friendAdded.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.friendAdded.TypeId);
			this.friendAdded.Serialize(writer);
		}
	}
}