using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeReplayStopMessage : NetworkMessage
	{
		public const uint Id = 6001;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6001;
			}
		}

		public ExchangeReplayStopMessage()
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