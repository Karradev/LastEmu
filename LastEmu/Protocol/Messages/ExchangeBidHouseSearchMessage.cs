using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseSearchMessage : NetworkMessage
	{
		public const uint Id = 5806;

		public uint type;

		public uint genId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5806;
			}
		}

		public ExchangeBidHouseSearchMessage()
		{
		}

		public ExchangeBidHouseSearchMessage(uint type, uint genId)
		{
			this.type = type;
			this.genId = genId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.type = reader.ReadVarUhInt();
			this.genId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.type);
			writer.WriteVarShort((int)this.genId);
		}
	}
}