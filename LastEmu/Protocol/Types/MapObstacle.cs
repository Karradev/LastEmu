using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class MapObstacle
	{
		public const short Id = 200;

		public uint obstacleCellId;

		public sbyte state;

		public virtual short TypeId
		{
			get
			{
				return 200;
			}
		}

		public MapObstacle()
		{
		}

		public MapObstacle(uint obstacleCellId, sbyte state)
		{
			this.obstacleCellId = obstacleCellId;
			this.state = state;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.obstacleCellId = reader.ReadVarUhShort();
			this.state = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.obstacleCellId);
			writer.WriteSByte(this.state);
		}
	}
}