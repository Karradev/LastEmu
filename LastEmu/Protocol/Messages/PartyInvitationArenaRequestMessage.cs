using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyInvitationArenaRequestMessage : PartyInvitationRequestMessage
	{
		public const uint Id = 6283;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6283;
			}
		}

		public PartyInvitationArenaRequestMessage()
		{
		}

		public PartyInvitationArenaRequestMessage(string name) : base(name)
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