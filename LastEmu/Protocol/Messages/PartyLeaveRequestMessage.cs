using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyLeaveRequestMessage : AbstractPartyMessage
	{
		public const uint Id = 5593;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5593;
			}
		}

		public PartyLeaveRequestMessage()
		{
		}

		public PartyLeaveRequestMessage(uint partyId) : base(partyId)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}