using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HouseGuildNoneMessage : NetworkMessage
	{
		public const uint Id = 5701;

		public uint houseId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5701;
			}
		}

		public HouseGuildNoneMessage()
		{
		}

		public HouseGuildNoneMessage(uint houseId)
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