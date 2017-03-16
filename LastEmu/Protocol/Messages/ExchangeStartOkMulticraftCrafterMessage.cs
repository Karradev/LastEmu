using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkMulticraftCrafterMessage : NetworkMessage
	{
		public const uint Id = 5818;

		public uint skillId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5818;
			}
		}

		public ExchangeStartOkMulticraftCrafterMessage()
		{
		}

		public ExchangeStartOkMulticraftCrafterMessage(uint skillId)
		{
			this.skillId = skillId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.skillId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.skillId);
		}
	}
}