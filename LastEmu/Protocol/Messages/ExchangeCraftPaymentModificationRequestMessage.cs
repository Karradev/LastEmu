using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeCraftPaymentModificationRequestMessage : NetworkMessage
	{
		public const uint Id = 6579;

		public uint quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6579;
			}
		}

		public ExchangeCraftPaymentModificationRequestMessage()
		{
		}

		public ExchangeCraftPaymentModificationRequestMessage(uint quantity)
		{
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.quantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.quantity);
		}
	}
}