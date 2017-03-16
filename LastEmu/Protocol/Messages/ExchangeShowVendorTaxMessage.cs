using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeShowVendorTaxMessage : NetworkMessage
	{
		public const uint Id = 5783;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5783;
			}
		}

		public ExchangeShowVendorTaxMessage()
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