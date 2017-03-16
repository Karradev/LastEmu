using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceGuildLeavingMessage : NetworkMessage
	{
		public const uint Id = 6399;

		public bool kicked;

		public uint guildId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6399;
			}
		}

		public AllianceGuildLeavingMessage()
		{
		}

		public AllianceGuildLeavingMessage(bool kicked, uint guildId)
		{
			this.kicked = kicked;
			this.guildId = guildId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.kicked = reader.ReadBoolean();
			this.guildId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.kicked);
			writer.WriteVarInt((int)this.guildId);
		}
	}
}