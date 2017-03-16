using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class HouseToSellListMessage : NetworkMessage
	{
		public const uint Id = 6140;

		public uint pageIndex;

		public uint totalPage;

		public HouseInformationsForSell[] houseList;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6140;
			}
		}

		public HouseToSellListMessage()
		{
		}

		public HouseToSellListMessage(uint pageIndex, uint totalPage, HouseInformationsForSell[] houseList)
		{
			this.pageIndex = pageIndex;
			this.totalPage = totalPage;
			this.houseList = houseList;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.pageIndex = reader.ReadVarUhShort();
			this.totalPage = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.houseList = new HouseInformationsForSell[num];
			for (int i = 0; i < num; i++)
			{
				this.houseList[i] = new HouseInformationsForSell();
				this.houseList[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.pageIndex);
			writer.WriteVarShort((int)this.totalPage);
			writer.WriteShort((short)((int)this.houseList.Length));
			HouseInformationsForSell[] houseInformationsForSellArray = this.houseList;
			for (int i = 0; i < (int)houseInformationsForSellArray.Length; i++)
			{
				houseInformationsForSellArray[i].Serialize(writer);
			}
		}
	}
}