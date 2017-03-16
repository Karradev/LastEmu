using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class JobDescriptionMessage : NetworkMessage
	{
		public const uint Id = 5655;

		public JobDescription[] jobsDescription;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5655;
			}
		}

		public JobDescriptionMessage()
		{
		}

		public JobDescriptionMessage(JobDescription[] jobsDescription)
		{
			this.jobsDescription = jobsDescription;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.jobsDescription = new JobDescription[num];
			for (int i = 0; i < num; i++)
			{
				this.jobsDescription[i] = new JobDescription();
				this.jobsDescription[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.jobsDescription.Length));
			JobDescription[] jobDescriptionArray = this.jobsDescription;
			for (int i = 0; i < (int)jobDescriptionArray.Length; i++)
			{
				jobDescriptionArray[i].Serialize(writer);
			}
		}
	}
}