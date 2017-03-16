using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseGenericItemRemovedMessage : NetworkMessage
	{
		public const uint Id = 5948;

		public uint objGenericId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5948;
			}
		}

		public ExchangeBidHouseGenericItemRemovedMessage()
		{
		}

		public ExchangeBidHouseGenericItemRemovedMessage(uint objGenericId)
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