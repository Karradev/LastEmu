using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class BasicNamedAllianceInformations : BasicAllianceInformations
	{
		public const short Id = 418;

		public string allianceName;

		public override short TypeId
		{
			get
			{
				return 418;
			}
		}

		public BasicNamedAllianceInformations()
		{
		}

		public BasicNamedAllianceInformations(uint allianceId, string allianceTag, string allianceName) : base(allianceId, allianceTag)
		{
			this.allianceName = allianceName;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.allianceName = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.allianceName);
		}
	}
}