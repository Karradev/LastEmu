using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightMonsterInformations : GameFightAIInformations
	{
		public const short Id = 29;

		public uint creatureGenericId;

		public sbyte creatureGrade;

		public override short TypeId
		{
			get
			{
				return 29;
			}
		}

		public GameFightMonsterInformations()
		{
		}

		public GameFightMonsterInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, GameFightMinimalStats stats, uint[] previousPositions, uint creatureGenericId, sbyte creatureGrade) : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions)
		{
			this.creatureGenericId = creatureGenericId;
			this.creatureGrade = creatureGrade;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.creatureGenericId = reader.ReadVarUhShort();
			this.creatureGrade = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.creatureGenericId);
			writer.WriteSByte(this.creatureGrade);
		}
	}
}