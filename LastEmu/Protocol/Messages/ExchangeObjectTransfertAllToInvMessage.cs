using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeObjectTransfertAllToInvMessage : NetworkMessage
	{
		public const uint Id = 6032;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6032;
			}
		}

		public ExchangeObjectTransfertAllToInvMessage()
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