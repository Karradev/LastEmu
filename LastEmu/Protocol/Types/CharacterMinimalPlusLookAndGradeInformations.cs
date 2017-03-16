using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterMinimalPlusLookAndGradeInformations : CharacterMinimalPlusLookInformations
	{
		public const short Id = 193;

		public uint grade;

		public override short TypeId
		{
			get
			{
				return 193;
			}
		}

		public CharacterMinimalPlusLookAndGradeInformations()
		{
		}

		public CharacterMinimalPlusLookAndGradeInformations(double id, string name, byte level, EntityLook entityLook, uint grade) : base(id, name, level, entityLook)
		{
			this.grade = grade;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.grade = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.grade);
		}
	}
}