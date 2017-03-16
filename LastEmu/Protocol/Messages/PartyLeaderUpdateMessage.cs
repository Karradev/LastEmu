using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyLeaderUpdateMessage : AbstractPartyEventMessage
	{
		public const uint Id = 5578;

		public double partyLeaderId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5578;
			}
		}

		public PartyLeaderUpdateMessage()
		{
		}

		public PartyLeaderUpdateMessage(uint partyId, double partyLeaderId) : base(partyId)
		{
			this.partyLeaderId = partyLeaderId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.partyLeaderId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.partyLeaderId);
		}
	}
}