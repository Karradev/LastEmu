using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightAIInformations : GameFightFighterInformations
	{
		public const short Id = 151;

		public override short TypeId
		{
			get
			{
				return 151;
			}
		}

		public GameFightAIInformations()
		{
		}

		public GameFightAIInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, GameFightMinimalStats stats, uint[] previousPositions) : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}