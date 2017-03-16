using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeOnHumanVendorRequestMessage : NetworkMessage
	{
		public const uint Id = 5772;

		public double humanVendorId;

		public uint humanVendorCell;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5772;
			}
		}

		public ExchangeOnHumanVendorRequestMessage()
		{
		}

		public ExchangeOnHumanVendorRequestMessage(double humanVendorId, uint humanVendorCell)
		{
			this.humanVendorId = humanVendorId;
			this.humanVendorCell = humanVendorCell;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.humanVendorId = reader.ReadVarUhLong();
			this.humanVendorCell = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.humanVendorId);
			writer.WriteVarShort((int)this.humanVendorCell);
		}
	}
}