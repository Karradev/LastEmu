using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyNameSetRequestMessage : AbstractPartyMessage
	{
		public const uint Id = 6503;

		public string partyName;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6503;
			}
		}

		public PartyNameSetRequestMessage()
		{
		}

		public PartyNameSetRequestMessage(uint partyId, string partyName) : base(partyId)
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