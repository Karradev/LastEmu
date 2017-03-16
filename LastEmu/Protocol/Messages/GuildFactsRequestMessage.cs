using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildFactsRequestMessage : NetworkMessage
	{
		public const uint Id = 6404;

		public uint guildId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6404;
			}
		}

		public GuildFactsRequestMessage()
		{
		}

		public GuildFactsRequestMessage(uint guildId)
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