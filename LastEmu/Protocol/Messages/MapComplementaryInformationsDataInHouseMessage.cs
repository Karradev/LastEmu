using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MapComplementaryInformationsDataInHouseMessage : MapComplementaryInformationsDataMessage
	{
		public const uint Id = 6130;

		public HouseInformationsInside currentHouse;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6130;
			}
		}

		public MapComplementaryInformationsDataInHouseMessage()
		{
		}

		public MapComplementaryInformationsDataInHouseMessage(uint subAreaId, int mapId, HouseInformations[] houses, GameRolePlayActorInformations[] actors, InteractiveElement[] interactiveElements, StatedElement[] statedElements, MapObstacle[] obstacles, FightCommonInformations[] fights, bool hasAggressiveMonsters, HouseInformationsInside currentHouse) : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights, hasAggressiveMonsters)
		{
			this.currentHouse = currentHouse;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.currentHouse = new HouseInformationsInside();
			this.currentHouse.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.currentHouse.Serialize(writer);
		}
	}
}