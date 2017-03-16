using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeShopStockMultiMovementRemovedMessage : NetworkMessage
	{
		public const uint Id = 6037;

		public uint[] objectIdList;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6037;
			}
		}

		public ExchangeShopStockMultiMovementRemovedMessage()
		{
		}

		public ExchangeShopStockMultiMovementRemovedMessage(uint[] objectIdList)
		{
			this.objectIdList = objectIdList;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.objectIdList = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.objectIdList[i] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.objectIdList.Length));
			uint[] numArray = this.objectIdList;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt((int)numArray[i]);
			}
		}
	}
}