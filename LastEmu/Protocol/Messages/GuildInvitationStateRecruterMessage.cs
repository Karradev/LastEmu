using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildInvitationStateRecruterMessage : NetworkMessage
	{
		public const uint Id = 5563;

		public string recrutedName;

		public sbyte invitationState;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5563;
			}
		}

		public GuildInvitationStateRecruterMessage()
		{
		}

		public GuildInvitationStateRecruterMessage(string recrutedName, sbyte invitationState)
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