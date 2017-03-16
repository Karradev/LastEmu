using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class FriendUpdateMessage : NetworkMessage
	{
		public const uint Id = 5924;

		public FriendInformations friendUpdated;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5924;
			}
		}

		public FriendUpdateMessage()
		{
		}

		public FriendUpdateMessage(FriendInformations friendUpdated)
		{
			this.friendUpdated = friendUpdated;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.friendUpdated = ProtocolTypeManager.GetInstance<FriendInformations>(reader.ReadUShort());
			this.friendUpdated.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.friendUpdated.TypeId);
			this.friendUpdated.Serialize(writer);
		}
	}
}