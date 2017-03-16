using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyMemberRemoveMessage : AbstractPartyEventMessage
	{
		public const uint Id = 5579;

		public double leavingPlayerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5579;
			}
		}

		public PartyMemberRemoveMessage()
		{
		}

		public PartyMemberRemoveMessage(uint partyId, double leavingPlayerId) : base(partyId)
		{
			this.leavingPlayerId = leavingPlayerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.leavingPlayerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.leavingPlayerId);
		}
	}
}