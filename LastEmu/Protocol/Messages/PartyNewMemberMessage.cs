using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PartyNewMemberMessage : PartyUpdateMessage
	{
		public const uint Id = 6306;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6306;
			}
		}

		public PartyNewMemberMessage()
		{
		}

		public PartyNewMemberMessage(uint partyId, PartyMemberInformations memberInformations) : base(partyId, memberInformations)
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