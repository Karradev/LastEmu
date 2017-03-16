using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyFollowMemberRequestMessage : AbstractPartyMessage
	{
		public const uint Id = 5577;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5577;
			}
		}

		public PartyFollowMemberRequestMessage()
		{
		}

		public PartyFollowMemberRequestMessage(uint partyId, double playerId) : base(partyId)
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