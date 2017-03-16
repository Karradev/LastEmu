using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TreasureHuntStepDig : TreasureHuntStep
	{
		public const short Id = 465;

		public override short TypeId
		{
			get
			{
				return 465;
			}
		}

		public TreasureHuntStepDig()
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