using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyRestrictedMessage : AbstractPartyMessage
	{
		public const uint Id = 6175;

		public bool restricted;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6175;
			}
		}

		public PartyRestrictedMessage()
		{
		}

		public PartyRestrictedMessage(uint partyId, bool restricted) : base(partyId)
		{
			this.restricted = restricted;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.restricted = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(this.restricted);
		}
	}
}