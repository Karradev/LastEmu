using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FriendDeleteRequestMessage : NetworkMessage
	{
		public const uint Id = 5603;

		public int accountId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5603;
			}
		}

		public FriendDeleteRequestMessage()
		{
		}

		public FriendDeleteRequestMessage(int accountId)
		{
			this.accountId = accountId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.accountId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.accountId);
		}
	}
}