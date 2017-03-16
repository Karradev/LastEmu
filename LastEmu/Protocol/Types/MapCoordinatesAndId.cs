using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class MapCoordinatesAndId : MapCoordinates
	{
		public const short Id = 392;

		public int mapId;

		public override short TypeId
		{
			get
			{
				return 392;
			}
		}

		public MapCoordinatesAndId()
		{
		}

		public MapCoordinatesAndId(short worldX, short worldY, int mapId) : base(worldX, worldY)
		{
			this.mapId = mapId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.mapId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.mapId);
		}
	}
}