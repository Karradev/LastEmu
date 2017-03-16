using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyLeaveMessage : AbstractPartyMessage
	{
		public const uint Id = 5594;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5594;
			}
		}

		public PartyLeaveMessage()
		{
		}

		public PartyLeaveMessage(uint partyId) : base(partyId)
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