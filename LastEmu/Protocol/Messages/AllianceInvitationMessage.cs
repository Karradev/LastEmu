using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceInvitationMessage : NetworkMessage
	{
		public const uint Id = 6395;

		public double targetId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6395;
			}
		}

		public AllianceInvitationMessage()
		{
		}

		public AllianceInvitationMessage(double targetId)
		{
			this.targetId = targetId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.targetId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.targetId);
		}
	}
}