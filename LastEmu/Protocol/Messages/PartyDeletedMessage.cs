using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyDeletedMessage : AbstractPartyMessage
	{
		public const uint Id = 6261;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6261;
			}
		}

		public PartyDeletedMessage()
		{
		}

		public PartyDeletedMessage(uint partyId) : base(partyId)
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