using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildModificationEmblemValidMessage : NetworkMessage
	{
		public const uint Id = 6328;

		public GuildEmblem guildEmblem;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6328;
			}
		}

		public GuildModificationEmblemValidMessage()
		{
		}

		public GuildModificationEmblemValidMessage(GuildEmblem guildEmblem)
		{
			this.guildEmblem = guildEmblem;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.guildEmblem = new GuildEmblem();
			this.guildEmblem.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.guildEmblem.Serialize(writer);
		}
	}
}