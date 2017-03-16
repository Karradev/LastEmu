using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightMutantInformations : GameFightFighterNamedInformations
	{
		public const short Id = 50;

		public sbyte powerLevel;

		public override short TypeId
		{
			get
			{
				return 50;
			}
		}

		public GameFightMutantInformations()
		{
		}

		public GameFightMutantInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, GameFightMinimalStats stats, uint[] previousPositions, string name, PlayerStatus status, sbyte powerLevel) : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions, name, status)
		{
			this.powerLevel = powerLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.powerLevel = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.powerLevel);
		}
	}
}