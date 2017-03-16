using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class JobBookSubscription
	{
		public const short Id = 500;

		public sbyte jobId;

		public bool subscribed;

		public virtual short TypeId
		{
			get
			{
				return 500;
			}
		}

		public JobBookSubscription()
		{
		}

		public JobBookSubscription(sbyte jobId, bool subscribed)
		{
			this.jobId = jobId;
			this.subscribed = subscribed;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.jobId = reader.ReadSByte();
			this.subscribed = reader.ReadBoolean();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.jobId);
			writer.WriteBoolean(this.subscribed);
		}
	}
}