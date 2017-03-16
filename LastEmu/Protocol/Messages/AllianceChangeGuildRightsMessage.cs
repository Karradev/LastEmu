using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceChangeGuildRightsMessage : NetworkMessage
	{
		public const uint Id = 6426;

		public uint guildId;

		public sbyte rights;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6426;
			}
		}

		public AllianceChangeGuildRightsMessage()
		{
		}

		public AllianceChangeGuildRightsMessage(uint guildId, sbyte rights)
		{
			this.guildId = guildId;
			this.rights = rights;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.guildId = reader.ReadVarUhInt();
			this.rights = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.guildId);
			writer.WriteSByte(this.rights);
		}
	}
}