using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildModificationNameValidMessage : NetworkMessage
	{
		public const uint Id = 6327;

		public string guildName;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6327;
			}
		}

		public GuildModificationNameValidMessage()
		{
		}

		public GuildModificationNameValidMessage(string guildName)
		{
			this.guildName = guildName;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.guildName = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.guildName);
		}
	}
}