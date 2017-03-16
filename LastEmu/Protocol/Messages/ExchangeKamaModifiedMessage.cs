using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeKamaModifiedMessage : ExchangeObjectMessage
	{
		public const uint Id = 5521;

		public uint quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5521;
			}
		}

		public ExchangeKamaModifiedMessage()
		{
		}

		public ExchangeKamaModifiedMessage(bool remote, uint quantity) : base(remote)
		{
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.quantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.quantity);
		}
	}
}