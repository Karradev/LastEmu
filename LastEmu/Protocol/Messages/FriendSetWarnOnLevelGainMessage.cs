using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FriendSetWarnOnLevelGainMessage : NetworkMessage
	{
		public const uint Id = 6077;

		public bool enable;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6077;
			}
		}

		public FriendSetWarnOnLevelGainMessage()
		{
		}

		public FriendSetWarnOnLevelGainMessage(bool enable)
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