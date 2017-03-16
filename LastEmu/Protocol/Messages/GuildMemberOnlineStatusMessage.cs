using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildMemberOnlineStatusMessage : NetworkMessage
	{
		public const uint Id = 6061;

		public double memberId;

		public bool online;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6061;
			}
		}

		public GuildMemberOnlineStatusMessage()
		{
		}

		public GuildMemberOnlineStatusMessage(double memberId, bool online)
		{
			this.memberId = memberId;
			this.online = online;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.memberId = reader.ReadVarUhLong();
			this.online = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.memberId);
			writer.WriteBoolean(this.online);
		}
	}
}