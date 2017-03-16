using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterBaseInformations : CharacterMinimalPlusLookInformations
	{
		public const short Id = 45;

		public sbyte breed;

		public bool sex;

		public override short TypeId
		{
			get
			{
				return 45;
			}
		}

		public CharacterBaseInformations()
		{
		}

		public CharacterBaseInformations(double id, string name, byte level, EntityLook entityLook, sbyte breed, bool sex) : base(id, name, level, entityLook)
		{
			this.breed = breed;
			this.sex = sex;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.breed = reader.ReadSByte();
			this.sex = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.breed);
			writer.WriteBoolean(this.sex);
		}
	}
}