using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeStartedWithStorageMessage : ExchangeStartedMessage
	{
		public const uint Id = 6236;

		public uint storageMaxSlot;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6236;
			}
		}

		public ExchangeStartedWithStorageMessage()
		{
		}

		public ExchangeStartedWithStorageMessage(sbyte exchangeType, uint storageMaxSlot) : base(exchangeType)
		{
			this.storageMaxSlot = storageMaxSlot;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.storageMaxSlot = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.storageMaxSlot);
		}
	}
}