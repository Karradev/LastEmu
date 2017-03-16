using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterToRelookInformation : AbstractCharacterToRefurbishInformation
	{
		public const short Id = 399;

		public override short TypeId
		{
			get
			{
				return 399;
			}
		}

		public CharacterToRelookInformation()
		{
		}

		public CharacterToRelookInformation(double id, int[] colors, uint cosmeticId) : base(id, colors, cosmeticId)
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