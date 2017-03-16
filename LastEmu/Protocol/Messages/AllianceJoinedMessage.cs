using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AllianceJoinedMessage : NetworkMessage
	{
		public const uint Id = 6402;

		public AllianceInformations allianceInfo;

		public bool enabled;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6402;
			}
		}

		public AllianceJoinedMessage()
		{
		}

		public AllianceJoinedMessage(AllianceInformations allianceInfo, bool enabled)
		{
			this.allianceInfo = allianceInfo;
			this.enabled = enabled;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.allianceInfo = new AllianceInformations();
			this.allianceInfo.Deserialize(reader);
			this.enabled = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			this.allianceInfo.Serialize(writer);
			writer.WriteBoolean(this.enabled);
		}
	}
}