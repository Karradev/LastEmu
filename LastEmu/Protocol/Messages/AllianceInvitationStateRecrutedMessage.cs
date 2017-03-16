using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceInvitationStateRecrutedMessage : NetworkMessage
	{
		public const uint Id = 6392;

		public sbyte invitationState;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6392;
			}
		}

		public AllianceInvitationStateRecrutedMessage()
		{
		}

		public AllianceInvitationStateRecrutedMessage(sbyte invitationState)
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