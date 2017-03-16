using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterToRecolorInformation : AbstractCharacterToRefurbishInformation
	{
		public const short Id = 212;

		public override short TypeId
		{
			get
			{
				return 212;
			}
		}

		public CharacterToRecolorInformation()
		{
		}

		public CharacterToRecolorInformation(double id, int[] colors, uint cosmeticId) : base(id, colors, cosmeticId)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}