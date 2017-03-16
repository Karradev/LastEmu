using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SubscriptionZoneMessage : NetworkMessage
	{
		public const uint Id = 5573;

		public bool active;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5573;
			}
		}

		public SubscriptionZoneMessage()
		{
		}

		public SubscriptionZoneMessage(bool active)
		{
			this.active = active;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.active = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.active);
		}
	}
}