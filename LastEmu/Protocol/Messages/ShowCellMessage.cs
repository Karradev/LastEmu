using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ShowCellMessage : NetworkMessage
	{
		public const uint Id = 5612;

		public double sourceId;

		public uint cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5612;
			}
		}

		public ShowCellMessage()
		{
		}

		public ShowCellMessage(double sourceId, uint cellId)
		{
			this.sourceId = sourceId;
			this.cellId = cellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.sourceId = reader.ReadDouble();
			this.cellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.sourceId);
			writer.WriteVarShort((int)this.cellId);
		}
	}
}