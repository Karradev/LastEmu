using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterBasicMinimalInformations : AbstractCharacterInformation
	{
		public const short Id = 503;

		public string name;

		public override short TypeId
		{
			get
			{
				return 503;
			}
		}

		public CharacterBasicMinimalInformations()
		{
		}

		public CharacterBasicMinimalInformations(double id, string name) : base(id)
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