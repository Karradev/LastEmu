using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeAcceptMessage : NetworkMessage
	{
		public const uint Id = 5508;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5508;
			}
		}

		public ExchangeAcceptMessage()
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