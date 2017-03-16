using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeObjectTransfertExistingFromInvMessage : NetworkMessage
	{
		public const uint Id = 6325;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6325;
			}
		}

		public ExchangeObjectTransfertExistingFromInvMessage()
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