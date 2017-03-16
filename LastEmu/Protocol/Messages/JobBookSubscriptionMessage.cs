using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class JobBookSubscriptionMessage : NetworkMessage
	{
		public const uint Id = 6593;

		public JobBookSubscription[] subscriptions;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6593;
			}
		}

		public JobBookSubscriptionMessage()
		{
		}

		public JobBookSubscriptionMessage(JobBookSubscription[] subscriptions)
		{
			this.subscriptions = subscriptions;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.subscriptions = new JobBookSubscription[num];
			for (int i = 0; i < num; i++)
			{
				this.subscriptions[i] = new JobBookSubscription();
				this.subscriptions[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.subscriptions.Length));
			JobBookSubscription[] jobBookSubscriptionArray = this.subscriptions;
			for (int i = 0; i < (int)jobBookSubscriptionArray.Length; i++)
			{
				jobBookSubscriptionArray[i].Serialize(writer);
			}
		}
	}
}