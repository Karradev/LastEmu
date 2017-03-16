using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildHouseTeleportRequestMessage : NetworkMessage
	{
		public const uint Id = 5712;

		public uint houseId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5712;
			}
		}

		public GuildHouseTeleportRequestMessage()
		{
		}

		public GuildHouseTeleportRequestMessage(uint houseId)
		{
			this.houseId = houseId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.houseId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.houseId);
		}
	}
}