using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeIsReadyMessage : NetworkMessage
	{
		public const uint Id = 5509;

		public double id;

		public bool ready;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5509;
			}
		}

		public ExchangeIsReadyMessage()
		{
		}

		public ExchangeIsReadyMessage(double id, bool ready)
		{
			this.id = id;
			this.ready = ready;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadDouble();
			this.ready = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.id);
			writer.WriteBoolean(this.ready);
		}
	}
}