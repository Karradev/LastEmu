using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MapComplementaryInformationsDataInHavenBagMessage : MapComplementaryInformationsDataMessage
	{
		public const uint Id = 6622;

		public CharacterMinimalInformations ownerInformations;

		public sbyte theme;

		public sbyte roomId;

		public sbyte maxRoomId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6622;
			}
		}

		public MapComplementaryInformationsDataInHavenBagMessage()
		{
		}

		public MapComplementaryInformationsDataInHavenBagMessage(uint subAreaId, int mapId, HouseInformations[] houses, GameRolePlayActorInformations[] actors, InteractiveElement[] interactiveElements, StatedElement[] statedElements, MapObstacle[] obstacles, FightCommonInformations[] fights, bool hasAggressiveMonsters, CharacterMinimalInformations ownerInformations, sbyte theme, sbyte roomId, sbyte maxRoomId) : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights, hasAggressiveMonsters)
		{
			this.ownerInformations = ownerInformations;
			this.theme = theme;
			this.roomId = roomId;
			this.maxRoomId = maxRoomId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.ownerInformations = new CharacterMinimalInformations();
			this.ownerInformations.Deserialize(reader);
			this.theme = reader.ReadSByte();
			this.roomId = reader.ReadSByte();
			this.maxRoomId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.ownerInformations.Serialize(writer);
			writer.WriteSByte(this.theme);
			writer.WriteSByte(this.roomId);
			writer.WriteSByte(this.maxRoomId);
		}
	}
}