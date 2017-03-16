using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class HouseGuildRightsMessage : NetworkMessage
	{
		public const uint Id = 5703;

		public uint houseId;

		public GuildInformations guildInfo;

		public uint rights;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5703;
			}
		}

		public HouseGuildRightsMessage()
		{
		}

		public HouseGuildRightsMessage(uint houseId, GuildInformations guildInfo, uint rights)
		{
			this.houseId = houseId;
			this.guildInfo = guildInfo;
			this.rights = rights;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.houseId = reader.ReadVarUhInt();
			this.guildInfo = new GuildInformations();
			this.guildInfo.Deserialize(reader);
			this.rights = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.houseId);
			this.guildInfo.Serialize(writer);
			writer.WriteVarInt((int)this.rights);
		}
	}
}