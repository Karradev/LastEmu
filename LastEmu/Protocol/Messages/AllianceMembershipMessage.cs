using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AllianceMembershipMessage : AllianceJoinedMessage
	{
		public const uint Id = 6390;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6390;
			}
		}

		public AllianceMembershipMessage()
		{
		}

		public AllianceMembershipMessage(AllianceInformations allianceInfo, bool enabled) : base(allianceInfo, enabled)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}