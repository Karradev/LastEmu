using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyLoyaltyStatusMessage : AbstractPartyMessage
	{
		public const uint Id = 6270;

		public bool loyal;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6270;
			}
		}

		public PartyLoyaltyStatusMessage()
		{
		}

		public PartyLoyaltyStatusMessage(uint partyId, bool loyal) : base(partyId)
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