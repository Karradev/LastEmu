using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeStoppedMessage : NetworkMessage
	{
		public const uint Id = 6589;

		public double id;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6589;
			}
		}

		public ExchangeStoppedMessage()
		{
		}

		public ExchangeStoppedMessage(double id)
		{
			this.id = id;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.id);
		}
	}
}