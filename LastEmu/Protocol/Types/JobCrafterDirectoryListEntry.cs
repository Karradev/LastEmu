using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class JobCrafterDirectoryListEntry
	{
		public const short Id = 196;

		public JobCrafterDirectoryEntryPlayerInfo playerInfo;

		public JobCrafterDirectoryEntryJobInfo jobInfo;

		public virtual short TypeId
		{
			get
			{
				return 196;
			}
		}

		public JobCrafterDirectoryListEntry()
		{
		}

		public JobCrafterDirectoryListEntry(JobCrafterDirectoryEntryPlayerInfo playerInfo, JobCrafterDirectoryEntryJobInfo jobInfo)
		{
			this.playerInfo = playerInfo;
			this.jobInfo = jobInfo;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.playerInfo = new JobCrafterDirectoryEntryPlayerInfo();
			this.playerInfo.Deserialize(reader);
			this.jobInfo = new JobCrafterDirectoryEntryJobInfo();
			this.jobInfo.Deserialize(reader);
		}

		public virtual void Serialize(IDataWriter writer)
		{
			this.playerInfo.Serialize(writer);
			this.jobInfo.Serialize(writer);
		}
	}
}