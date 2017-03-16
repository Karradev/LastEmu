using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class AbstractPartyEventMessage : AbstractPartyMessage
	{
		public const uint Id = 6273;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6273;
			}
		}

		public AbstractPartyEventMessage()
		{
		}

		public AbstractPartyEventMessage(uint partyId) : base(partyId)
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