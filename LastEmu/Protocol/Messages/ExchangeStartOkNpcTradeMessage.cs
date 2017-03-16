using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkNpcTradeMessage : NetworkMessage
	{
		public const uint Id = 5785;

		public double npcId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5785;
			}
		}

		public ExchangeStartOkNpcTradeMessage()
		{
		}

		public ExchangeStartOkNpcTradeMessage(double npcId)
		{
			this.npcId = npcId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.npcId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.npcId);
		}
	}
}