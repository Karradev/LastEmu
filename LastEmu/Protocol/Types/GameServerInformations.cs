using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameServerInformations
	{
		public const short Id = 25;

		public uint id;

		public sbyte type;

		public sbyte status;

		public sbyte completion;

		public bool isSelectable;

		public sbyte charactersCount;

		public sbyte charactersSlots;

		public double date;

		public virtual short TypeId
		{
			get
			{
				return 25;
			}
		}

		public GameServerInformations()
		{
		}

		public GameServerInformations(uint id, sbyte type, sbyte status, sbyte completion, bool isSelectable, sbyte charactersCount, sbyte charactersSlots, double date)
		{
			this.id = id;
			this.type = type;
			this.status = status;
			this.completion = completion;
			this.isSelectable = isSelectable;
			this.charactersCount = charactersCount;
			this.charactersSlots = charactersSlots;
			this.date = date;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhShort();
			this.type = reader.ReadSByte();
			this.status = reader.ReadSByte();
			this.completion = reader.ReadSByte();
			this.isSelectable = reader.ReadBoolean();
			this.charactersCount = reader.ReadSByte();
			this.charactersSlots = reader.ReadSByte();
			this.date = reader.ReadDouble();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.id);
			writer.WriteSByte(this.type);
			writer.WriteSByte(this.status);
			writer.WriteSByte(this.completion);
			writer.WriteBoolean(this.isSelectable);
			writer.WriteSByte(this.charactersCount);
			writer.WriteSByte(this.charactersSlots);
			writer.WriteDouble(this.date);
		}
	}
}