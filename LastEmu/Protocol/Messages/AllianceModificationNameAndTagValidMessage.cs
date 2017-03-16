using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceModificationNameAndTagValidMessage : NetworkMessage
	{
		public const uint Id = 6449;

		public string allianceName;

		public string allianceTag;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6449;
			}
		}

		public AllianceModificationNameAndTagValidMessage()
		{
		}

		public AllianceModificationNameAndTagValidMessage(string allianceName, string allianceTag)
		{
			this.allianceName = allianceName;
			this.allianceTag = allianceTag;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.allianceName = reader.ReadUTF();
			this.allianceTag = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.allianceName);
			writer.WriteUTF(this.allianceTag);
		}
	}
}