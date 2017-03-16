using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkMulticraftCustomerMessage : NetworkMessage
	{
		public const uint Id = 5817;

		public uint skillId;

		public byte crafterJobLevel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5817;
			}
		}

		public ExchangeStartOkMulticraftCustomerMessage()
		{
		}

		public ExchangeStartOkMulticraftCustomerMessage(uint skillId, byte crafterJobLevel)
		{
			this.skillId = skillId;
			this.crafterJobLevel = crafterJobLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.skillId = reader.ReadVarUhInt();
			this.crafterJobLevel = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.skillId);
			writer.WriteByte(this.crafterJobLevel);
		}
	}
}