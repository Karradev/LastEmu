using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightFighterTaxCollectorLightInformations : GameFightFighterLightInformations
	{
		public const short Id = 457;

		public uint firstNameId;

		public uint lastNameId;

		public override short TypeId
		{
			get
			{
				return 457;
			}
		}

		public GameFightFighterTaxCollectorLightInformations()
		{
		}

		public GameFightFighterTaxCollectorLightInformations(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed, uint firstNameId, uint lastNameId) : base(sex, alive, id, wave, level, breed)
		{
			this.firstNameId = firstNameId;
			this.lastNameId = lastNameId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.firstNameId = reader.ReadVarUhShort();
			this.lastNameId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.firstNameId);
			writer.WriteVarShort((int)this.lastNameId);
		}
	}
}