using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyNameUpdateMessage : AbstractPartyMessage
	{
		public const uint Id = 6502;

		public string partyName;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6502;
			}
		}

		public PartyNameUpdateMessage()
		{
		}

		public PartyNameUpdateMessage(uint partyId, string partyName) : base(partyId)
		{
			this.partyName = partyName;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.partyName = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.partyName);
		}
	}
}