using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
	{
		public const uint Id = 6251;

		public double cancelerId;

		public double guestId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6251;
			}
		}

		public PartyCancelInvitationNotificationMessage()
		{
		}

		public PartyCancelInvitationNotificationMessage(uint partyId, double cancelerId, double guestId) : base(partyId)
		{
			this.cancelerId = cancelerId;
			this.guestId = guestId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.cancelerId = reader.ReadVarUhLong();
			this.guestId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.cancelerId);
			writer.WriteVarLong(this.guestId);
		}
	}
}