using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyCancelInvitationMessage : AbstractPartyMessage
	{
		public const uint Id = 6254;

		public double guestId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6254;
			}
		}

		public PartyCancelInvitationMessage()
		{
		}

		public PartyCancelInvitationMessage(uint partyId, double guestId) : base(partyId)
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