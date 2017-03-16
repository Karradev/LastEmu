using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeObjectTransfertAllFromInvMessage : NetworkMessage
	{
		public const uint Id = 6184;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6184;
			}
		}

		public ExchangeObjectTransfertAllFromInvMessage()
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