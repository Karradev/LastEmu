using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FriendSpouseFollowWithCompassRequestMessage : NetworkMessage
	{
		public const uint Id = 5606;

		public bool enable;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5606;
			}
		}

		public FriendSpouseFollowWithCompassRequestMessage()
		{
		}

		public FriendSpouseFollowWithCompassRequestMessage(bool enable)
		{
			this.enable = enable;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.enable = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.enable);
		}
	}
}