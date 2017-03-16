using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TreasureHuntStepFight : TreasureHuntStep
	{
		public const short Id = 462;

		public override short TypeId
		{
			get
			{
				return 462;
			}
		}

		public TreasureHuntStepFight()
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