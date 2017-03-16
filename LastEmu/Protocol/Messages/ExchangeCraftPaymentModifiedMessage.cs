using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeCraftPaymentModifiedMessage : NetworkMessage
	{
		public const uint Id = 6578;

		public uint goldSum;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6578;
			}
		}

		public ExchangeCraftPaymentModifiedMessage()
		{
		}

		public ExchangeCraftPaymentModifiedMessage(uint goldSum)
		{
			this.goldSum = goldSum;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.goldSum = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.goldSum);
		}
	}
}