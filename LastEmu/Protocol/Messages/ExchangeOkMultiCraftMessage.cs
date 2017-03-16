using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeOkMultiCraftMessage : NetworkMessage
	{
		public const uint Id = 5768;

		public double initiatorId;

		public double otherId;

		public sbyte role;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5768;
			}
		}

		public ExchangeOkMultiCraftMessage()
		{
		}

		public ExchangeOkMultiCraftMessage(double initiatorId, double otherId, sbyte role)
		{
			this.initiatorId = initiatorId;
			this.otherId = otherId;
			this.role = role;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.initiatorId = reader.ReadVarUhLong();
			this.otherId = reader.ReadVarUhLong();
			this.role = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.initiatorId);
			writer.WriteVarLong(this.otherId);
			writer.WriteSByte(this.role);
		}
	}
}