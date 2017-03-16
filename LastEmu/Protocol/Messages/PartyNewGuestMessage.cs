using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PartyNewGuestMessage : AbstractPartyEventMessage
	{
		public const uint Id = 6260;

		public PartyGuestInformations guest;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6260;
			}
		}

		public PartyNewGuestMessage()
		{
		}

		public PartyNewGuestMessage(uint partyId, PartyGuestInformations guest) : base(partyId)
		{
			this.guest = guest;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.guest = new PartyGuestInformations();
			this.guest.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.guest.Serialize(writer);
		}
	}
}