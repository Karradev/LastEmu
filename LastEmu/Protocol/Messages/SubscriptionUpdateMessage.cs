using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SubscriptionUpdateMessage : NetworkMessage
	{
		public const uint Id = 6616;

		public double timestamp;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6616;
			}
		}

		public SubscriptionUpdateMessage()
		{
		}

		public SubscriptionUpdateMessage(double timestamp)
		{
			this.timestamp = timestamp;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.timestamp = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.timestamp);
		}
	}
}