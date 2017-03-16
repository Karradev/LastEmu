using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ShowCellRequestMessage : NetworkMessage
	{
		public const uint Id = 5611;

		public uint cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5611;
			}
		}

		public ShowCellRequestMessage()
		{
		}

		public ShowCellRequestMessage(uint cellId)
		{
			this.cellId = cellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.cellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.cellId);
		}
	}
}