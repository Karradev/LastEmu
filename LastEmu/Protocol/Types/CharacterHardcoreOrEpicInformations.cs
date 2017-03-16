using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterHardcoreOrEpicInformations : CharacterBaseInformations
	{
		public const short Id = 474;

		public sbyte deathState;

		public uint deathCount;

		public byte deathMaxLevel;

		public override short TypeId
		{
			get
			{
				return 474;
			}
		}

		public CharacterHardcoreOrEpicInformations()
		{
		}

		public CharacterHardcoreOrEpicInformations(double id, string name, byte level, EntityLook entityLook, sbyte breed, bool sex, sbyte deathState, uint deathCount, byte deathMaxLevel) : base(id, name, level, entityLook, breed, sex)
		{
			this.deathState = deathState;
			this.deathCount = deathCount;
			this.deathMaxLevel = deathMaxLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.deathState = reader.ReadSByte();
			this.deathCount = reader.ReadVarUhShort();
			this.deathMaxLevel = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.deathState);
			writer.WriteVarShort((int)this.deathCount);
			writer.WriteByte(this.deathMaxLevel);
		}
	}
}