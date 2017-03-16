using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GuildEmblem
	{
		public const short Id = 87;

		public uint symbolShape;

		public int symbolColor;

		public sbyte backgroundShape;

		public int backgroundColor;

		public virtual short TypeId
		{
			get
			{
				return 87;
			}
		}

		public GuildEmblem()
		{
		}

		public GuildEmblem(uint symbolShape, int symbolColor, sbyte backgroundShape, int backgroundColor)
		{
			this.symbolShape = symbolShape;
			this.symbolColor = symbolColor;
			this.backgroundShape = backgroundShape;
			this.backgroundColor = backgroundColor;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.symbolShape = reader.ReadVarUhShort();
			this.symbolColor = reader.ReadInt();
			this.backgroundShape = reader.ReadSByte();
			this.backgroundColor = reader.ReadInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.symbolShape);
			writer.WriteInt(this.symbolColor);
			writer.WriteSByte(this.backgroundShape);
			writer.WriteInt(this.backgroundColor);
		}
	}
}