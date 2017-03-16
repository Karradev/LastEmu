using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightMonsterWithAlignmentInformations : GameFightMonsterInformations
	{
		public const short Id = 203;

		public ActorAlignmentInformations alignmentInfos;

		public override short TypeId
		{
			get
			{
				return 203;
			}
		}

		public GameFightMonsterWithAlignmentInformations()
		{
		}

		public GameFightMonsterWithAlignmentInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, GameFightMinimalStats stats, uint[] previousPositions, uint creatureGenericId, sbyte creatureGrade, ActorAlignmentInformations alignmentInfos) : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions, creatureGenericId, creatureGrade)
		{
			this.alignmentInfos = alignmentInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.alignmentInfos = new ActorAlignmentInformations();
			this.alignmentInfos.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.alignmentInfos.Serialize(writer);
		}
	}
}