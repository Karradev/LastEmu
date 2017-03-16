using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildJoinedMessage : NetworkMessage
	{
		public const uint Id = 5564;

		public GuildInformations guildInfo;

		public uint memberRights;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5564;
			}
		}

		public GuildJoinedMessage()
		{
		}

		public GuildJoinedMessage(GuildInformations guildInfo, uint memberRights)
		{
			this.guildInfo = guildInfo;
			this.memberRights = memberRights;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.guildInfo = new GuildInformations();
			this.guildInfo.Deserialize(reader);
			this.memberRights = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			this.guildInfo.Serialize(writer);
			writer.WriteVarInt((int)this.memberRights);
		}
	}
}