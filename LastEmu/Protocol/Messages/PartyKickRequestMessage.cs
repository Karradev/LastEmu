using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyKickRequestMessage : AbstractPartyMessage
	{
		public const uint Id = 5592;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5592;
			}
		}

		public PartyKickRequestMessage()
		{
		}

		public PartyKickRequestMessage(uint partyId, double playerId) : base(partyId)
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