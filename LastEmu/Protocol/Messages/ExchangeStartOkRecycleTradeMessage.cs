using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkRecycleTradeMessage : NetworkMessage
	{
		public const uint Id = 6600;

		public short percentToPrism;

		public short percentToPlayer;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6600;
			}
		}

		public ExchangeStartOkRecycleTradeMessage()
		{
		}

		public ExchangeStartOkRecycleTradeMessage(short percentToPrism, short percentToPlayer)
		{
			this.percentToPrism = percentToPrism;
			this.percentToPlayer = percentToPlayer;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.percentToPrism = reader.ReadShort();
			this.percentToPlayer = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.percentToPrism);
			writer.WriteShort(this.percentToPlayer);
		}
	}
}