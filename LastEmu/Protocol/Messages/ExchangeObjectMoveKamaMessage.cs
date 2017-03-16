using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeObjectMoveKamaMessage : NetworkMessage
	{
		public const uint Id = 5520;

		public int quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5520;
			}
		}

		public ExchangeObjectMoveKamaMessage()
		{
		}

		public ExchangeObjectMoveKamaMessage(int quantity)
		{
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.quantity = reader.ReadVarInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(this.quantity);
		}
	}
}