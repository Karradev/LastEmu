using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PartyUpdateMessage : AbstractPartyEventMessage
	{
		public const uint Id = 5575;

		public PartyMemberInformations memberInformations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5575;
			}
		}

		public PartyUpdateMessage()
		{
		}

		public PartyUpdateMessage(uint partyId, PartyMemberInformations memberInformations) : base(partyId)
		{
			this.memberInformations = memberInformations;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.memberInformations = ProtocolTypeManager.GetInstance<PartyMemberInformations>(reader.ReadUShort());
			this.memberInformations.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.memberInformations.TypeId);
			this.memberInformations.Serialize(writer);
		}
	}
}