using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeReplyTaxVendorMessage : NetworkMessage
	{
		public const uint Id = 5787;

		public uint objectValue;

		public uint totalTaxValue;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5787;
			}
		}

		public ExchangeReplyTaxVendorMessage()
		{
		}

		public ExchangeReplyTaxVendorMessage(uint objectValue, uint totalTaxValue)
		{
			this.objectValue = objectValue;
			this.totalTaxValue = totalTaxValue;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectValue = reader.ReadVarUhInt();
			this.totalTaxValue = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectValue);
			writer.WriteVarInt((int)this.totalTaxValue);
		}
	}
}