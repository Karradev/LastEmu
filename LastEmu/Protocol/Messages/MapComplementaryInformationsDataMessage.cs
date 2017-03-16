using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MapComplementaryInformationsDataMessage : NetworkMessage
	{
		public const uint Id = 226;

		public uint subAreaId;

		public int mapId;

		public HouseInformations[] houses;

		public GameRolePlayActorInformations[] actors;

		public InteractiveElement[] interactiveElements;

		public StatedElement[] statedElements;

		public MapObstacle[] obstacles;

		public FightCommonInformations[] fights;

		public bool hasAggressiveMonsters;

		public override uint ProtocolId
		{
			get
			{
				return (uint)226;
			}
		}

		public MapComplementaryInformationsDataMessage()
		{
		}

		public MapComplementaryInformationsDataMessage(uint subAreaId, int mapId, HouseInformations[] houses, GameRolePlayActorInformations[] actors, InteractiveElement[] interactiveElements, StatedElement[] statedElements, MapObstacle[] obstacles, FightCommonInformations[] fights, bool hasAggressiveMonsters)
		{
			this.subAreaId = subAreaId;
			this.mapId = mapId;
			this.houses = houses;
			this.actors = actors;
			this.interactiveElements = interactiveElements;
			this.statedElements = statedElements;
			this.obstacles = obstacles;
			this.fights = fights;
			this.hasAggressiveMonsters = hasAggressiveMonsters;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
			this.mapId = reader.ReadInt();
			ushort num = reader.ReadUShort();
			this.houses = new HouseInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.houses[i] = ProtocolTypeManager.GetInstance<HouseInformations>(reader.ReadUShort());
				this.houses[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.actors = new GameRolePlayActorInformations[num];
			for (int j = 0; j < num; j++)
			{
				this.actors[j] = ProtocolTypeManager.GetInstance<GameRolePlayActorInformations>(reader.ReadUShort());
				this.actors[j].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.interactiveElements = new InteractiveElement[num];
			for (int k = 0; k < num; k++)
			{
				this.interactiveElements[k] = ProtocolTypeManager.GetInstance<InteractiveElement>(reader.ReadUShort());
				this.interactiveElements[k].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.statedElements = new StatedElement[num];
			for (int l = 0; l < num; l++)
			{
				this.statedElements[l] = new StatedElement();
				this.statedElements[l].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.obstacles = new MapObstacle[num];
			for (int m = 0; m < num; m++)
			{
				this.obstacles[m] = new MapObstacle();
				this.obstacles[m].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.fights = new FightCommonInformations[num];
			for (int n = 0; n < num; n++)
			{
				this.fights[n] = new FightCommonInformations();
				this.fights[n].Deserialize(reader);
			}
			this.hasAggressiveMonsters = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteInt(this.mapId);
			writer.WriteShort((short)((int)this.houses.Length));
			HouseInformations[] houseInformationsArray = this.houses;
			for (int i = 0; i < (int)houseInformationsArray.Length; i++)
			{
				HouseInformations houseInformation = houseInformationsArray[i];
				writer.WriteShort(houseInformation.TypeId);
				houseInformation.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.actors.Length));
			GameRolePlayActorInformations[] gameRolePlayActorInformationsArray = this.actors;
			for (int j = 0; j < (int)gameRolePlayActorInformationsArray.Length; j++)
			{
				GameRolePlayActorInformations gameRolePlayActorInformation = gameRolePlayActorInformationsArray[j];
				writer.WriteShort(gameRolePlayActorInformation.TypeId);
				gameRolePlayActorInformation.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.interactiveElements.Length));
			InteractiveElement[] interactiveElementArray = this.interactiveElements;
			for (int k = 0; k < (int)interactiveElementArray.Length; k++)
			{
				InteractiveElement interactiveElement = interactiveElementArray[k];
				writer.WriteShort(interactiveElement.TypeId);
				interactiveElement.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.statedElements.Length));
			StatedElement[] statedElementArray = this.statedElements;
			for (int l = 0; l < (int)statedElementArray.Length; l++)
			{
				statedElementArray[l].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.obstacles.Length));
			MapObstacle[] mapObstacleArray = this.obstacles;
			for (int m = 0; m < (int)mapObstacleArray.Length; m++)
			{
				mapObstacleArray[m].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.fights.Length));
			FightCommonInformations[] fightCommonInformationsArray = this.fights;
			for (int n = 0; n < (int)fightCommonInformationsArray.Length; n++)
			{
				fightCommonInformationsArray[n].Serialize(writer);
			}
			writer.WriteBoolean(this.hasAggressiveMonsters);
		}
	}
}