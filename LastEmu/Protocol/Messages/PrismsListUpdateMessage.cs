using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PrismsListUpdateMessage : PrismsListMessage
	{
		public const uint Id = 6438;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6438;
			}
		}

		public PrismsListUpdateMessage()
		{
		}

		public PrismsListUpdateMessage(PrismSubareaEmptyInfo[] prisms) : base(prisms)
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