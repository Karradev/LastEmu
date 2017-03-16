using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameActionMark
	{
		public const short Id = 351;

		public double markAuthorId;

		public sbyte markTeamId;

		public int markSpellId;

		public short markSpellLevel;

		public short markId;

		public sbyte markType;

		public short markimpactCell;

		public GameActionMarkedCell[] cells;

		public bool active;

		public virtual short TypeId
		{
			get
			{
				return 351;
			}
		}

		public GameActionMark()
		{
		}

		public GameActionMark(double markAuthorId, sbyte markTeamId, int markSpellId, short markSpellLevel, short markId, sbyte markType, short markimpactCell, GameActionMarkedCell[] cells, bool active)
		{
			this.markAuthorId = markAuthorId;
			this.markTeamId = markTeamId;
			this.markSpellId = markSpellId;
			this.markSpellLevel = markSpellLevel;
			this.markId = markId;
			this.markType = markType;
			this.markimpactCell = markimpactCell;
			this.cells = cells;
			this.active = active;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.markAuthorId = reader.ReadDouble();
			this.markTeamId = reader.ReadSByte();
			this.markSpellId = reader.ReadInt();
			this.markSpellLevel = reader.ReadShort();
			this.markId = reader.ReadShort();
			this.markType = reader.ReadSByte();
			this.markimpactCell = reader.ReadShort();
			ushort num = reader.ReadUShort();
			this.cells = new GameActionMarkedCell[num];
			for (int i = 0; i < num; i++)
			{
				this.cells[i] = new GameActionMarkedCell();
				this.cells[i].Deserialize(reader);
			}
			this.active = reader.ReadBoolean();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.markAuthorId);
			writer.WriteSByte(this.markTeamId);
			writer.WriteInt(this.markSpellId);
			writer.WriteShort(this.markSpellLevel);
			writer.WriteShort(this.markId);
			writer.WriteSByte(this.markType);
			writer.WriteShort(this.markimpactCell);
			writer.WriteShort((short)((int)this.cells.Length));
			GameActionMarkedCell[] gameActionMarkedCellArray = this.cells;
			for (int i = 0; i < (int)gameActionMarkedCellArray.Length; i++)
			{
				gameActionMarkedCellArray[i].Serialize(writer);
			}
			writer.WriteBoolean(this.active);
		}
	}
}