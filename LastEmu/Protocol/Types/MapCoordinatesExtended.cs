using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class MapCoordinatesExtended : MapCoordinatesAndId
	{
		public const short Id = 176;

		public uint subAreaId;

		public override short TypeId
		{
			get
			{
				return 176;
			}
		}

		public MapCoordinatesExtended()
		{
		}

		public MapCoordinatesExtended(short worldX, short worldY, int mapId, uint subAreaId) : base(worldX, worldY, mapId)
		{
			this.subAreaId = subAreaId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.subAreaId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.subAreaId);
		}
	}
}