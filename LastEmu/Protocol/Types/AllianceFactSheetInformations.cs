using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AllianceFactSheetInformations : AllianceInformations
	{
		public const short Id = 421;

		public int creationDate;

		public override short TypeId
		{
			get
			{
				return 421;
			}
		}

		public AllianceFactSheetInformations()
		{
		}

		public AllianceFactSheetInformations(uint allianceId, string allianceTag, string allianceName, GuildEmblem allianceEmblem, int creationDate) : base(allianceId, allianceTag, allianceName, allianceEmblem)
		{
			this.creationDate = creationDate;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.creationDate = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.creationDate);
		}
	}
}