using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightCompanionInformations : GameFightFighterInformations
	{
		public const short Id = 450;

		public sbyte companionGenericId;

		public byte level;

		public double masterId;

		public override short TypeId
		{
			get
			{
				return 450;
			}
		}

		public GameFightCompanionInformations()
		{
		}

		public GameFightCompanionInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, GameFightMinimalStats stats, uint[] previousPositions, sbyte companionGenericId, byte level, double masterId) : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions)
		{
			this.companionGenericId = companionGenericId;
			this.level = level;
			this.masterId = masterId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.companionGenericId = reader.ReadSByte();
			this.level = reader.ReadByte();
			this.masterId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.companionGenericId);
			writer.WriteByte(this.level);
			writer.WriteDouble(this.masterId);
		}
	}
}