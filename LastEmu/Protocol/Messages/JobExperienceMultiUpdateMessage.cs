using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class JobExperienceMultiUpdateMessage : NetworkMessage
	{
		public const uint Id = 5809;

		public JobExperience[] experiencesUpdate;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5809;
			}
		}

		public JobExperienceMultiUpdateMessage()
		{
		}

		public JobExperienceMultiUpdateMessage(JobExperience[] experiencesUpdate)
		{
			this.experiencesUpdate = experiencesUpdate;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.experiencesUpdate = new JobExperience[num];
			for (int i = 0; i < num; i++)
			{
				this.experiencesUpdate[i] = new JobExperience();
				this.experiencesUpdate[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.experiencesUpdate.Length));
			JobExperience[] jobExperienceArray = this.experiencesUpdate;
			for (int i = 0; i < (int)jobExperienceArray.Length; i++)
			{
				jobExperienceArray[i].Serialize(writer);
			}
		}
	}
}