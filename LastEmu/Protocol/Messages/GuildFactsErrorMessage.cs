using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildFactsErrorMessage : NetworkMessage
	{
		public const uint Id = 6424;

		public uint guildId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6424;
			}
		}

		public GuildFactsErrorMessage()
		{
		}

		public GuildFactsErrorMessage(uint guildId)
		{
			this.guildId = guildId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.guildId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.guildId);
		}
	}
}