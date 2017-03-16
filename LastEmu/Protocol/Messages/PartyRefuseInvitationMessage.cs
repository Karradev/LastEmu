using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyRefuseInvitationMessage : AbstractPartyMessage
	{
		public const uint Id = 5582;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5582;
			}
		}

		public PartyRefuseInvitationMessage()
		{
		}

		public PartyRefuseInvitationMessage(uint partyId) : base(partyId)
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