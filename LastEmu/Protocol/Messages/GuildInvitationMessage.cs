using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildInvitationMessage : NetworkMessage
	{
		public const uint Id = 5551;

		public double targetId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5551;
			}
		}

		public GuildInvitationMessage()
		{
		}

		public GuildInvitationMessage(double targetId)
		{
			this.targetId = targetId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.targetId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.targetId);
		}
	}
}