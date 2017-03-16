using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PaddockToSellListMessage : NetworkMessage
	{
		public const uint Id = 6138;

		public uint pageIndex;

		public uint totalPage;

		public PaddockInformationsForSell[] paddockList;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6138;
			}
		}

		public PaddockToSellListMessage()
		{
		}

		public PaddockToSellListMessage(uint pageIndex, uint totalPage, PaddockInformationsForSell[] paddockList)
		{
			this.pageIndex = pageIndex;
			this.totalPage = totalPage;
			this.paddockList = paddockList;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.pageIndex = reader.ReadVarUhShort();
			this.totalPage = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.paddockList = new PaddockInformationsForSell[num];
			for (int i = 0; i < num; i++)
			{
				this.paddockList[i] = new PaddockInformationsForSell();
				this.paddockList[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.pageIndex);
			writer.WriteVarShort((int)this.totalPage);
			writer.WriteShort((short)((int)this.paddockList.Length));
			PaddockInformationsForSell[] paddockInformationsForSellArray = this.paddockList;
			for (int i = 0; i < (int)paddockInformationsForSellArray.Length; i++)
			{
				paddockInformationsForSellArray[i].Serialize(writer);
			}
		}
	}
}