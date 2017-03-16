using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DebugHighlightCellsMessage : NetworkMessage
	{
		public const uint Id = 2001;

		public int color;

		public uint[] cells;

		public override uint ProtocolId
		{
			get
			{
				return (uint)2001;
			}
		}

		public DebugHighlightCellsMessage()
		{
		}

		public DebugHighlightCellsMessage(int color, uint[] cells)
		{
			this.color = color;
			this.cells = cells;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.color = reader.ReadInt();
			ushort num = reader.ReadUShort();
			this.cells = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.cells[i] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.color);
			writer.WriteShort((short)((int)this.cells.Length));
			uint[] numArray = this.cells;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
		}
	}
}