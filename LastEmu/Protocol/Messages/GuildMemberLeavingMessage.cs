using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildMemberLeavingMessage : NetworkMessage
	{
		public const uint Id = 5923;

		public bool kicked;

		public double memberId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5923;
			}
		}

		public GuildMemberLeavingMessage()
		{
		}

		public GuildMemberLeavingMessage(bool kicked, double memberId)
		{
			this.kicked = kicked;
			this.memberId = memberId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.kicked = reader.ReadBoolean();
			this.memberId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.kicked);
			writer.WriteVarLong(this.memberId);
		}
	}
}