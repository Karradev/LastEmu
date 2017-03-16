using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FriendSpouseJoinRequestMessage : NetworkMessage
	{
		public const uint Id = 5604;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5604;
			}
		}

		public FriendSpouseJoinRequestMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}