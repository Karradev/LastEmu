using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FriendWarnOnConnectionStateMessage : NetworkMessage
	{
		public const uint Id = 5630;

		public bool enable;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5630;
			}
		}

		public FriendWarnOnConnectionStateMessage()
		{
		}

		public FriendWarnOnConnectionStateMessage(bool enable)
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