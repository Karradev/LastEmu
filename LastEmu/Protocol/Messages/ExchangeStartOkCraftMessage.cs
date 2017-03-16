using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkCraftMessage : NetworkMessage
	{
		public const uint Id = 5813;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5813;
			}
		}

		public ExchangeStartOkCraftMessage()
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