using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyKickedByMessage : AbstractPartyMessage
	{
		public const uint Id = 5590;

		public double kickerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5590;
			}
		}

		public PartyKickedByMessage()
		{
		}

		public PartyKickedByMessage(uint partyId, double kickerId) : base(partyId)
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