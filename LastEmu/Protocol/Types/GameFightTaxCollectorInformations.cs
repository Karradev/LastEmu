using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightTaxCollectorInformations : GameFightAIInformations
	{
		public const short Id = 48;

		public uint firstNameId;

		public uint lastNameId;

		public byte level;

		public override short TypeId
		{
			get
			{
				return 48;
			}
		}

		public GameFightTaxCollectorInformations()
		{
		}

		public GameFightTaxCollectorInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, GameFightMinimalStats stats, uint[] previousPositions, uint firstNameId, uint lastNameId, byte level) : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions)
		{
			this.firstNameId = firstNameId;
			this.lastNameId = lastNameId;
			this.level = level;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.firstNameId = reader.ReadVarUhShort();
			this.lastNameId = reader.ReadVarUhShort();
			this.level = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.firstNameId);
			writer.WriteVarShort((int)this.lastNameId);
			writer.WriteByte(this.level);
		}
	}
}