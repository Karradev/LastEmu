using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyAcceptInvitationMessage : AbstractPartyMessage
	{
		public const uint Id = 5580;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5580;
			}
		}

		public PartyAcceptInvitationMessage()
		{
		}

		public PartyAcceptInvitationMessage(uint partyId) : base(partyId)
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