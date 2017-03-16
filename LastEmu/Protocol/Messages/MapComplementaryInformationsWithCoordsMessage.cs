using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MapComplementaryInformationsWithCoordsMessage : MapComplementaryInformationsDataMessage
	{
		public const uint Id = 6268;

		public short worldX;

		public short worldY;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6268;
			}
		}

		public MapComplementaryInformationsWithCoordsMessage()
		{
		}

		public MapComplementaryInformationsWithCoordsMessage(uint subAreaId, int mapId, HouseInformations[] houses, GameRolePlayActorInformations[] actors, InteractiveElement[] interactiveElements, StatedElement[] statedElements, MapObstacle[] obstacles, FightCommonInformations[] fights, bool hasAggressiveMonsters, short worldX, short worldY) : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights, hasAggressiveMonsters)
		{
			this.worldX = worldX;
			this.worldY = worldY;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
		}
	}
}