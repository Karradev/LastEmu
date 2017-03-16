using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseTypeMessage : NetworkMessage
	{
		public const uint Id = 5803;

		public uint type;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5803;
			}
		}

		public ExchangeBidHouseTypeMessage()
		{
		}

		public ExchangeBidHouseTypeMessage(uint type)
		{
			this.type = type;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.type = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.type);
		}
	}
}