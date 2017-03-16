using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildKickRequestMessage : NetworkMessage
	{
		public const uint Id = 5887;

		public double kickedId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5887;
			}
		}

		public GuildKickRequestMessage()
		{
		}

		public GuildKickRequestMessage(double kickedId)
		{
			this.kickedId = kickedId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.kickedId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.kickedId);
		}
	}
}