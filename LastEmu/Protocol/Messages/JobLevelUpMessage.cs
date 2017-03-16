using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class JobLevelUpMessage : NetworkMessage
	{
		public const uint Id = 5656;

		public byte newLevel;

		public JobDescription jobsDescription;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5656;
			}
		}

		public JobLevelUpMessage()
		{
		}

		public JobLevelUpMessage(byte newLevel, JobDescription jobsDescription)
		{
			this.newLevel = newLevel;
			this.jobsDescription = jobsDescription;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.newLevel = reader.ReadByte();
			this.jobsDescription = new JobDescription();
			this.jobsDescription.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteByte(this.newLevel);
			this.jobsDescription.Serialize(writer);
		}
	}
}