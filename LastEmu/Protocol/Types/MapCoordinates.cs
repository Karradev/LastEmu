using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class MapCoordinates
	{
		public const short Id = 174;

		public short worldX;

		public short worldY;

		public virtual short TypeId
		{
			get
			{
				return 174;
			}
		}

		public MapCoordinates()
		{
		}

		public MapCoordinates(short worldX, short worldY)
		{
			this.worldX = worldX;
			this.worldY = worldY;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
		}
	}
}