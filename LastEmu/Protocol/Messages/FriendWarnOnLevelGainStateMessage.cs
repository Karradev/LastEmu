using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FriendWarnOnLevelGainStateMessage : NetworkMessage
	{
		public const uint Id = 6078;

		public bool enable;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6078;
			}
		}

		public FriendWarnOnLevelGainStateMessage()
		{
		}

		public FriendWarnOnLevelGainStateMessage(bool enable)
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