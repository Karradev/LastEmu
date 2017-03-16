using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyStopFollowRequestMessage : AbstractPartyMessage
	{
		public const uint Id = 5574;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5574;
			}
		}

		public PartyStopFollowRequestMessage()
		{
		}

		public PartyStopFollowRequestMessage(uint partyId, double playerId) : base(partyId)
		{
			this.playerId = playerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.playerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.playerId);
		}
	}
}