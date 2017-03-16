using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightFighterNamedLightInformations : GameFightFighterLightInformations
	{
		public const short Id = 456;

		public string name;

		public override short TypeId
		{
			get
			{
				return 456;
			}
		}

		public GameFightFighterNamedLightInformations()
		{
		}

		public GameFightFighterNamedLightInformations(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed, string name) : base(sex, alive, id, wave, level, breed)
		{
			this.name = name;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.name = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.name);
		}
	}
}