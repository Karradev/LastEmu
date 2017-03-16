using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class JobExperienceUpdateMessage : NetworkMessage
	{
		public const uint Id = 5654;

		public JobExperience experiencesUpdate;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5654;
			}
		}

		public JobExperienceUpdateMessage()
		{
		}

		public JobExperienceUpdateMessage(JobExperience experiencesUpdate)
		{
			this.experiencesUpdate = experiencesUpdate;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.experiencesUpdate = new JobExperience();
			this.experiencesUpdate.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.experiencesUpdate.Serialize(writer);
		}
	}
}