using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TreasureHuntFlag
	{
		public const short Id = 473;

		public int mapId;

		public sbyte state;

		public virtual short TypeId
		{
			get
			{
				return 473;
			}
		}

		public TreasureHuntFlag()
		{
		}

		public TreasureHuntFlag(int mapId, sbyte state)
		{
			this.mapId = mapId;
			this.state = state;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.mapId = reader.ReadInt();
			this.state = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.mapId);
			writer.WriteSByte(this.state);
		}
	}
}