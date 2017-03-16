using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyMemberEjectedMessage : PartyMemberRemoveMessage
	{
		public const uint Id = 6252;

		public double kickerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6252;
			}
		}

		public PartyMemberEjectedMessage()
		{
		}

		public PartyMemberEjectedMessage(uint partyId, double leavingPlayerId, double kickerId) : base(partyId, leavingPlayerId)
		{
			this.kickerId = kickerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.kickerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.kickerId);
		}
	}
}