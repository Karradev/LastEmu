using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HumanOptionAlliance : HumanOption
	{
		public const short Id = 425;

		public AllianceInformations allianceInformations;

		public sbyte aggressable;

		public override short TypeId
		{
			get
			{
				return 425;
			}
		}

		public HumanOptionAlliance()
		{
		}

		public HumanOptionAlliance(AllianceInformations allianceInformations, sbyte aggressable)
		{
			this.allianceInformations = allianceInformations;
			this.aggressable = aggressable;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.allianceInformations = new AllianceInformations();
			this.allianceInformations.Deserialize(reader);
			this.aggressable = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.allianceInformations.Serialize(writer);
			writer.WriteSByte(this.aggressable);
		}
	}
}