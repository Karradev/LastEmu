using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismModuleExchangeRequestMessage : NetworkMessage
	{
		public const uint Id = 6531;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6531;
			}
		}

		public PrismModuleExchangeRequestMessage()
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