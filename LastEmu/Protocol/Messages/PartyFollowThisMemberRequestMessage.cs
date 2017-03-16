using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyFollowThisMemberRequestMessage : PartyFollowMemberRequestMessage
	{
		public const uint Id = 5588;

		public bool enabled;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5588;
			}
		}

		public PartyFollowThisMemberRequestMessage()
		{
		}

		public PartyFollowThisMemberRequestMessage(uint partyId, double playerId, bool enabled) : base(partyId, playerId)
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