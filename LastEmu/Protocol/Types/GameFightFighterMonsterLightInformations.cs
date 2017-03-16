using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightFighterMonsterLightInformations : GameFightFighterLightInformations
	{
		public const short Id = 455;

		public uint creatureGenericId;

		public override short TypeId
		{
			get
			{
				return 455;
			}
		}

		public GameFightFighterMonsterLightInformations()
		{
		}

		public GameFightFighterMonsterLightInformations(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed, uint creatureGenericId) : base(sex, alive, id, wave, level, breed)
		{
			this.creatureGenericId = creatureGenericId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.creatureGenericId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.creatureGenericId);
		}
	}
}