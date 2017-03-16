using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class IdolPartyRefreshMessage : NetworkMessage
	{
		public const uint Id = 6583;

		public PartyIdol partyIdol;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6583;
			}
		}

		public IdolPartyRefreshMessage()
		{
		}

		public IdolPartyRefreshMessage(PartyIdol partyIdol)
		{
			this.partyIdol = partyIdol;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.partyIdol = new PartyIdol();
			this.partyIdol.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.partyIdol.Serialize(writer);
		}
	}
}