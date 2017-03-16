using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildModificationValidMessage : NetworkMessage
	{
		public const uint Id = 6323;

		public string guildName;

		public GuildEmblem guildEmblem;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6323;
			}
		}

		public GuildModificationValidMessage()
		{
		}

		public GuildModificationValidMessage(string guildName, GuildEmblem guildEmblem)
		{
			this.guildName = guildName;
			this.guildEmblem = guildEmblem;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.guildName = reader.ReadUTF();
			this.guildEmblem = new GuildEmblem();
			this.guildEmblem.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.guildName);
			this.guildEmblem.Serialize(writer);
		}
	}
}