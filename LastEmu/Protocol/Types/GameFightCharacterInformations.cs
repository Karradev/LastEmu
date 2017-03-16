using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightCharacterInformations : GameFightFighterNamedInformations
	{
		public const short Id = 46;

		public byte level;

		public ActorAlignmentInformations alignmentInfos;

		public sbyte breed;

		public bool sex;

		public override short TypeId
		{
			get
			{
				return 46;
			}
		}

		public GameFightCharacterInformations()
		{
		}

		public GameFightCharacterInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, GameFightMinimalStats stats, uint[] previousPositions, string name, PlayerStatus status, byte level, ActorAlignmentInformations alignmentInfos, sbyte breed, bool sex) : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions, name, status)
		{
			this.level = level;
			this.alignmentInfos = alignmentInfos;
			this.breed = breed;
			this.sex = sex;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.level = reader.ReadByte();
			this.alignmentInfos = new ActorAlignmentInformations();
			this.alignmentInfos.Deserialize(reader);
			this.breed = reader.ReadSByte();
			this.sex = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(this.level);
			this.alignmentInfos.Serialize(writer);
			writer.WriteSByte(this.breed);
			writer.WriteBoolean(this.sex);
		}
	}
}