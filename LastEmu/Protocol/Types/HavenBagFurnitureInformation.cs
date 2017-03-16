using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HavenBagFurnitureInformation
	{
		public const short Id = 498;

		public uint cellId;

		public int funitureId;

		public sbyte orientation;

		public virtual short TypeId
		{
			get
			{
				return 498;
			}
		}

		public HavenBagFurnitureInformation()
		{
		}

		public HavenBagFurnitureInformation(uint cellId, int funitureId, sbyte orientation)
		{
			this.cellId = cellId;
			this.funitureId = funitureId;
			this.orientation = orientation;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.cellId = reader.ReadVarUhShort();
			this.funitureId = reader.ReadInt();
			this.orientation = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.cellId);
			writer.WriteInt(this.funitureId);
			writer.WriteSByte(this.orientation);
		}
	}
}