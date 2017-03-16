using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildInvitationAnswerMessage : NetworkMessage
	{
		public const uint Id = 5556;

		public bool accept;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5556;
			}
		}

		public GuildInvitationAnswerMessage()
		{
		}

		public GuildInvitationAnswerMessage(bool accept)
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