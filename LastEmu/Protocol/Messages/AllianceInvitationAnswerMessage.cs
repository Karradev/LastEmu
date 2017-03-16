using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceInvitationAnswerMessage : NetworkMessage
	{
		public const uint Id = 6401;

		public bool accept;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6401;
			}
		}

		public AllianceInvitationAnswerMessage()
		{
		}

		public AllianceInvitationAnswerMessage(bool accept)
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