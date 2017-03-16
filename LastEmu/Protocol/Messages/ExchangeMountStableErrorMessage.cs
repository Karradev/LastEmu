using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeMountStableErrorMessage : NetworkMessage
	{
		public const uint Id = 5981;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5981;
			}
		}

		public ExchangeMountStableErrorMessage()
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