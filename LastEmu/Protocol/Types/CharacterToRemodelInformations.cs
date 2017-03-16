using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterToRemodelInformations : CharacterRemodelingInformation
	{
		public const short Id = 477;

		public sbyte possibleChangeMask;

		public sbyte mandatoryChangeMask;

		public override short TypeId
		{
			get
			{
				return 477;
			}
		}

		public CharacterToRemodelInformations()
		{
		}

		public CharacterToRemodelInformations(double id, string name, sbyte breed, bool sex, uint cosmeticId, int[] colors, sbyte possibleChangeMask, sbyte mandatoryChangeMask) : base(id, name, breed, sex, cosmeticId, colors)
		{
			this.possibleChangeMask = possibleChangeMask;
			this.mandatoryChangeMask = mandatoryChangeMask;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.possibleChangeMask = reader.ReadSByte();
			this.mandatoryChangeMask = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.possibleChangeMask);
			writer.WriteSByte(this.mandatoryChangeMask);
		}
	}
}