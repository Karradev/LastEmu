using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class PartyCannotJoinErrorMessage : AbstractPartyMessage
	{
		public const uint Id = 5583;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5583;
			}
		}

		public PartyCannotJoinErrorMessage()
		{
		}

		public PartyCannotJoinErrorMessage(uint partyId, sbyte reason) : base(partyId)
		{
			this.reason = reason;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.reason = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.reason);
		}
	}
}