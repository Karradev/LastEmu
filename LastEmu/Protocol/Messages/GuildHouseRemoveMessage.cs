using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildHouseRemoveMessage : NetworkMessage
	{
		public const uint Id = 6180;

		public uint houseId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6180;
			}
		}

		public GuildHouseRemoveMessage()
		{
		}

		public GuildHouseRemoveMessage(uint houseId)
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