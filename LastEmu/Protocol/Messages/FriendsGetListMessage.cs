using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FriendsGetListMessage : NetworkMessage
	{
		public const uint Id = 4001;

		public override uint ProtocolId
		{
			get
			{
				return (uint)4001;
			}
		}

		public FriendsGetListMessage()
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