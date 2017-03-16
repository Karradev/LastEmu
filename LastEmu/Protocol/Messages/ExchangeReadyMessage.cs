using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeReadyMessage : NetworkMessage
	{
		public const uint Id = 5511;

		public bool ready;

		public uint step;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5511;
			}
		}

		public ExchangeReadyMessage()
		{
		}

		public ExchangeReadyMessage(bool ready, uint step)
		{
			this.ready = ready;
			this.step = step;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.ready = reader.ReadBoolean();
			this.step = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.ready);
			writer.WriteVarShort((int)this.step);
		}
	}
}