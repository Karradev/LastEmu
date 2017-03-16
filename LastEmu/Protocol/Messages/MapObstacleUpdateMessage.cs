using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MapObstacleUpdateMessage : NetworkMessage
	{
		public const uint Id = 6051;

		public MapObstacle[] obstacles;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6051;
			}
		}

		public MapObstacleUpdateMessage()
		{
		}

		public MapObstacleUpdateMessage(MapObstacle[] obstacles)
		{
			this.obstacles = obstacles;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.obstacles = new MapObstacle[num];
			for (int i = 0; i < num; i++)
			{
				this.obstacles[i] = new MapObstacle();
				this.obstacles[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.obstacles.Length));
			MapObstacle[] mapObstacleArray = this.obstacles;
			for (int i = 0; i < (int)mapObstacleArray.Length; i++)
			{
				mapObstacleArray[i].Serialize(writer);
			}
		}
	}
}