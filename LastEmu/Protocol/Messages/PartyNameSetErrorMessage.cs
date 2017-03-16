using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyNameSetErrorMessage : AbstractPartyMessage
	{
		public const uint Id = 6501;

		public sbyte result;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6501;
			}
		}

		public PartyNameSetErrorMessage()
		{
		}

		public PartyNameSetErrorMessage(uint partyId, sbyte result) : base(partyId)
		{
			this.result = result;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.result = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.result);
		}
	}
}