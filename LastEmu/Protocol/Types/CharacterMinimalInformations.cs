using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterMinimalInformations : CharacterBasicMinimalInformations
	{
		public const short Id = 110;

		public byte level;

		public override short TypeId
		{
			get
			{
				return 110;
			}
		}

		public CharacterMinimalInformations()
		{
		}

		public CharacterMinimalInformations(double id, string name, byte level) : base(id, name)
		{
			this.level = level;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.level = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(this.level);
		}
	}
}