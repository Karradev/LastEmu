using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildInvitationStateRecrutedMessage : NetworkMessage
	{
		public const uint Id = 5548;

		public sbyte invitationState;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5548;
			}
		}

		public GuildInvitationStateRecrutedMessage()
		{
		}

		public GuildInvitationStateRecrutedMessage(sbyte invitationState)
		{
			this.invitationState = invitationState;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.invitationState = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.invitationState);
		}
	}
}