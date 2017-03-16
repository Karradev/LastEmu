using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TeleportBuddiesAnswerMessage : NetworkMessage
	{
		public const uint Id = 6294;

		public bool accept;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6294;
			}
		}

		public TeleportBuddiesAnswerMessage()
		{
		}

		public TeleportBuddiesAnswerMessage(bool accept)
		{
			this.accept = accept;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.accept = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.accept);
		}
	}
}