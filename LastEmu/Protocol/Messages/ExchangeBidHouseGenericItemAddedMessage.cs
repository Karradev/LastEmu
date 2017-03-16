using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseGenericItemAddedMessage : NetworkMessage
	{
		public const uint Id = 5947;

		public uint objGenericId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5947;
			}
		}

		public ExchangeBidHouseGenericItemAddedMessage()
		{
		}

		public ExchangeBidHouseGenericItemAddedMessage(uint objGenericId)
		{
			this.objGenericId = objGenericId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objGenericId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.objGenericId);
		}
	}
}