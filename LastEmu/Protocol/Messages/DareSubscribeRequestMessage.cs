using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DareSubscribeRequestMessage : NetworkMessage
	{
		public const uint Id = 6666;

		public double dareId;

		public bool subscribe;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6666;
			}
		}

		public DareSubscribeRequestMessage()
		{
		}

		public DareSubscribeRequestMessage(double dareId, bool subscribe)
		{
			this.dareId = dareId;
			this.subscribe = subscribe;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dareId = reader.ReadDouble();
			this.subscribe = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.dareId);
			writer.WriteBoolean(this.subscribe);
		}
	}
}