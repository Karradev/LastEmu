using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidHousePriceMessage : NetworkMessage
	{
		public const uint Id = 5805;

		public uint genId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5805;
			}
		}

		public ExchangeBidHousePriceMessage()
		{
		}

		public ExchangeBidHousePriceMessage(uint genId)
		{
			this.genId = genId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.genId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.genId);
		}
	}
}