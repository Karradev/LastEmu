using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeItemAutoCraftStopedMessage : NetworkMessage
	{
		public const uint Id = 5810;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5810;
			}
		}

		public ExchangeItemAutoCraftStopedMessage()
		{
		}

		public ExchangeItemAutoCraftStopedMessage(sbyte reason)
		{
			this.reason = reason;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.reason = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.reason);
		}
	}
}