using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyPledgeLoyaltyRequestMessage : AbstractPartyMessage
	{
		public const uint Id = 6269;

		public bool loyal;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6269;
			}
		}

		public PartyPledgeLoyaltyRequestMessage()
		{
		}

		public PartyPledgeLoyaltyRequestMessage(uint partyId, bool loyal) : base(partyId)
		{
			this.loyal = loyal;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.loyal = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(this.loyal);
		}
	}
}