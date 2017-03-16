using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ContactLookRequestByIdMessage : ContactLookRequestMessage
	{
		public const uint Id = 5935;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5935;
			}
		}

		public ContactLookRequestByIdMessage()
		{
		}

		public ContactLookRequestByIdMessage(byte requestId, sbyte contactType, double playerId) : base(requestId, contactType)
		{
			this.playerId = playerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.playerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.playerId);
		}
	}
}