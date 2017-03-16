using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SubscriptionLimitationMessage : NetworkMessage
	{
		public const uint Id = 5542;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5542;
			}
		}

		public SubscriptionLimitationMessage()
		{
		}

		public SubscriptionLimitationMessage(sbyte reason)
		{
			this.reason = reason;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.reason = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.reason);
		}
	}
}