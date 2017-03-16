using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyRefuseInvitationNotificationMessage : AbstractPartyEventMessage
	{
		public const uint Id = 5596;

		public double guestId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5596;
			}
		}

		public PartyRefuseInvitationNotificationMessage()
		{
		}

		public PartyRefuseInvitationNotificationMessage(uint partyId, double guestId) : base(partyId)
		{
			this.guestId = guestId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.guestId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.guestId);
		}
	}
}