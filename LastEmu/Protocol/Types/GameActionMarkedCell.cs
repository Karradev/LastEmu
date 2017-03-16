using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameActionMarkedCell
	{
		public const short Id = 85;

		public uint cellId;

		public sbyte zoneSize;

		public int cellColor;

		public sbyte cellsType;

		public virtual short TypeId
		{
			get
			{
				return 85;
			}
		}

		public GameActionMarkedCell()
		{
		}

		public GameActionMarkedCell(uint cellId, sbyte zoneSize, int cellColor, sbyte cellsType)
		{
			this.cellId = cellId;
			this.zoneSize = zoneSize;
			this.cellColor = cellColor;
			this.cellsType = cellsType;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.cellId = reader.ReadVarUhShort();
			this.zoneSize = reader.ReadSByte();
			this.cellColor = reader.ReadInt();
			this.cellsType = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.cellId);
			writer.WriteSByte(this.zoneSize);
			writer.WriteInt(this.cellColor);
			writer.WriteSByte(this.cellsType);
		}
	}
}