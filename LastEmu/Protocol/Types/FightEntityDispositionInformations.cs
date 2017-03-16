using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightEntityDispositionInformations : EntityDispositionInformations
	{
		public const short Id = 217;

		public double carryingCharacterId;

		public override short TypeId
		{
			get
			{
				return 217;
			}
		}

		public FightEntityDispositionInformations()
		{
		}

		public FightEntityDispositionInformations(short cellId, sbyte direction, double carryingCharacterId) : base(cellId, direction)
		{
			this.carryingCharacterId = carryingCharacterId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.carryingCharacterId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.carryingCharacterId);
		}
	}
}