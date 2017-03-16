using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyInvitationCancelledForGuestMessage : AbstractPartyMessage
	{
		public const uint Id = 6256;

		public double cancelerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6256;
			}
		}

		public PartyInvitationCancelledForGuestMessage()
		{
		}

		public PartyInvitationCancelledForGuestMessage(uint partyId, double cancelerId) : base(partyId)
		{
			this.cancelerId = cancelerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.cancelerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.cancelerId);
		}
	}
}