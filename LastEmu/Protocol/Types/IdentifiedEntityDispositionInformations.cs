using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class IdentifiedEntityDispositionInformations : EntityDispositionInformations
	{
		public const short Id = 107;

		public double id;

		public override short TypeId
		{
			get
			{
				return 107;
			}
		}

		public IdentifiedEntityDispositionInformations()
		{
		}

		public IdentifiedEntityDispositionInformations(short cellId, sbyte direction, double id) : base(cellId, direction)
		{
			this.id = id;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.id);
		}
	}
}