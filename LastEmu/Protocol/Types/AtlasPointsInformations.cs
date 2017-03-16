using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AtlasPointsInformations
	{
		public const short Id = 175;

		public sbyte type;

		public MapCoordinatesExtended[] coords;

		public virtual short TypeId
		{
			get
			{
				return 175;
			}
		}

		public AtlasPointsInformations()
		{
		}

		public AtlasPointsInformations(sbyte type, MapCoordinatesExtended[] coords)
		{
			this.type = type;
			this.coords = coords;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.type = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.coords = new MapCoordinatesExtended[num];
			for (int i = 0; i < num; i++)
			{
				this.coords[i] = new MapCoordinatesExtended();
				this.coords[i].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.type);
			writer.WriteShort((short)((int)this.coords.Length));
			MapCoordinatesExtended[] mapCoordinatesExtendedArray = this.coords;
			for (int i = 0; i < (int)mapCoordinatesExtendedArray.Length; i++)
			{
				mapCoordinatesExtendedArray[i].Serialize(writer);
			}
		}
	}
}