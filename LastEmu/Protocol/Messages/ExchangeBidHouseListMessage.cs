using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseListMessage : NetworkMessage
	{
		public const uint Id = 5807;

		public uint id;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5807;
			}
		}

		public ExchangeBidHouseListMessage()
		{
		}

		public ExchangeBidHouseListMessage(uint id)
		{
			this.id = id;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.id);
		}
	}
}