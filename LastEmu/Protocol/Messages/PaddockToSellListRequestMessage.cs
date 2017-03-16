using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PaddockToSellListRequestMessage : NetworkMessage
	{
		public const uint Id = 6141;

		public uint pageIndex;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6141;
			}
		}

		public PaddockToSellListRequestMessage()
		{
		}

		public PaddockToSellListRequestMessage(uint pageIndex)
		{
			this.pageIndex = pageIndex;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.pageIndex = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.pageIndex);
		}
	}
}