using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class BasicAllianceInformations : AbstractSocialGroupInfos
	{
		public const short Id = 419;

		public uint allianceId;

		public string allianceTag;

		public override short TypeId
		{
			get
			{
				return 419;
			}
		}

		public BasicAllianceInformations()
		{
		}

		public BasicAllianceInformations(uint allianceId, string allianceTag)
		{
			this.allianceId = allianceId;
			this.allianceTag = allianceTag;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.allianceId = reader.ReadVarUhInt();
			this.allianceTag = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.allianceId);
			writer.WriteUTF(this.allianceTag);
		}
	}
}