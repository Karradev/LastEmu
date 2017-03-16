using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AllianceCreationValidMessage : NetworkMessage
	{
		public const uint Id = 6393;

		public string allianceName;

		public string allianceTag;

		public GuildEmblem allianceEmblem;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6393;
			}
		}

		public AllianceCreationValidMessage()
		{
		}

		public AllianceCreationValidMessage(string allianceName, string allianceTag, GuildEmblem allianceEmblem)
		{
			this.allianceName = allianceName;
			this.allianceTag = allianceTag;
			this.allianceEmblem = allianceEmblem;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.allianceName = reader.ReadUTF();
			this.allianceTag = reader.ReadUTF();
			this.allianceEmblem = new GuildEmblem();
			this.allianceEmblem.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.allianceName);
			writer.WriteUTF(this.allianceTag);
			this.allianceEmblem.Serialize(writer);
		}
	}
}