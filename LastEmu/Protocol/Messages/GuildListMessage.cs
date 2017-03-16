using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildListMessage : NetworkMessage
	{
		public const uint Id = 6413;

		public GuildInformations[] guilds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6413;
			}
		}

		public GuildListMessage()
		{
		}

		public GuildListMessage(GuildInformations[] guilds)
		{
			this.guilds = guilds;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.guilds = new GuildInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.guilds[i] = new GuildInformations();
				this.guilds[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.guilds.Length));
			GuildInformations[] guildInformationsArray = this.guilds;
			for (int i = 0; i < (int)guildInformationsArray.Length; i++)
			{
				guildInformationsArray[i].Serialize(writer);
			}
		}
	}
}