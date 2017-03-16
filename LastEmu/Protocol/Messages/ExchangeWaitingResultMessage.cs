using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeWaitingResultMessage : NetworkMessage
	{
		public const uint Id = 5786;

		public bool bwait;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5786;
			}
		}

		public ExchangeWaitingResultMessage()
		{
		}

		public ExchangeWaitingResultMessage(bool bwait)
		{
			this.bwait = bwait;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.bwait = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.bwait);
		}
	}
}