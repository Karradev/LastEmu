using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyLocateMembersRequestMessage : AbstractPartyMessage
	{
		public const uint Id = 5587;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5587;
			}
		}

		public PartyLocateMembersRequestMessage()
		{
		}

		public PartyLocateMembersRequestMessage(uint partyId) : base(partyId)
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