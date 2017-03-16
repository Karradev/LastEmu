using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyInvitationDetailsRequestMessage : AbstractPartyMessage
	{
		public const uint Id = 6264;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6264;
			}
		}

		public PartyInvitationDetailsRequestMessage()
		{
		}

		public PartyInvitationDetailsRequestMessage(uint partyId) : base(partyId)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}