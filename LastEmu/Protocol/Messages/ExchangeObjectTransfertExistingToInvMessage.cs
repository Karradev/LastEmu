using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeObjectTransfertExistingToInvMessage : NetworkMessage
	{
		public const uint Id = 6326;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6326;
			}
		}

		public ExchangeObjectTransfertExistingToInvMessage()
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