using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AllianceModificationEmblemValidMessage : NetworkMessage
	{
		public const uint Id = 6447;

		public GuildEmblem Alliancemblem;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6447;
			}
		}

		public AllianceModificationEmblemValidMessage()
		{
		}

		public AllianceModificationEmblemValidMessage(GuildEmblem Alliancemblem)
		{
			this.Alliancemblem = Alliancemblem;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.Alliancemblem = new GuildEmblem();
			this.Alliancemblem.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.Alliancemblem.Serialize(writer);
		}
	}
}