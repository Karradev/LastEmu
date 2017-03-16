using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeObjectMessage : NetworkMessage
	{
		public const uint Id = 5515;

		public bool remote;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5515;
			}
		}

		public ExchangeObjectMessage()
		{
		}

		public ExchangeObjectMessage(bool remote)
		{
			this.remote = remote;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.remote = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.remote);
		}
	}
}