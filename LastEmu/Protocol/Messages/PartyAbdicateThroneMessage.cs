using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyAbdicateThroneMessage : AbstractPartyMessage
	{
		public const uint Id = 6080;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6080;
			}
		}

		public PartyAbdicateThroneMessage()
		{
		}

		public PartyAbdicateThroneMessage(uint partyId, double playerId) : base(partyId)
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