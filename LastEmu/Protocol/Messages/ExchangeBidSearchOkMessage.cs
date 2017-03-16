using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidSearchOkMessage : NetworkMessage
	{
		public const uint Id = 5802;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5802;
			}
		}

		public ExchangeBidSearchOkMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}