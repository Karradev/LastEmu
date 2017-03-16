using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBuyOkMessage : NetworkMessage
	{
		public const uint Id = 5759;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5759;
			}
		}

		public ExchangeBuyOkMessage()
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