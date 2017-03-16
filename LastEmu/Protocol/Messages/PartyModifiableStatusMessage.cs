using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyModifiableStatusMessage : AbstractPartyMessage
	{
		public const uint Id = 6277;

		public bool enabled;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6277;
			}
		}

		public PartyModifiableStatusMessage()
		{
		}

		public PartyModifiableStatusMessage(uint partyId, bool enabled) : base(partyId)
		{
			this.enabled = enabled;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.enabled = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(this.enabled);
		}
	}
}