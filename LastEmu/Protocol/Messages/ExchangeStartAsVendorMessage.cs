using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeStartAsVendorMessage : NetworkMessage
	{
		public const uint Id = 5775;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5775;
			}
		}

		public ExchangeStartAsVendorMessage()
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