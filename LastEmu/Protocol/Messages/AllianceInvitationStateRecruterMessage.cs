using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceInvitationStateRecruterMessage : NetworkMessage
	{
		public const uint Id = 6396;

		public string recrutedName;

		public sbyte invitationState;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6396;
			}
		}

		public AllianceInvitationStateRecruterMessage()
		{
		}

		public AllianceInvitationStateRecruterMessage(string recrutedName, sbyte invitationState)
		{
			this.recrutedName = recrutedName;
			this.invitationState = invitationState;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.recrutedName = reader.ReadUTF();
			this.invitationState = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.recrutedName);
			writer.WriteSByte(this.invitationState);
		}
	}
}