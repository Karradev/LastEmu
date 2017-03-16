using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class JobCrafterDirectoryEntryJobInfo
	{
		public const short Id = 195;

		public sbyte jobId;

		public byte jobLevel;

		public bool free;

		public byte minLevel;

		public virtual short TypeId
		{
			get
			{
				return 195;
			}
		}

		public JobCrafterDirectoryEntryJobInfo()
		{
		}

		public JobCrafterDirectoryEntryJobInfo(sbyte jobId, byte jobLevel, bool free, byte minLevel)
		{
			this.jobId = jobId;
			this.jobLevel = jobLevel;
			this.free = free;
			this.minLevel = minLevel;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.jobId = reader.ReadSByte();
			this.jobLevel = reader.ReadByte();
			this.free = reader.ReadBoolean();
			this.minLevel = reader.ReadByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.jobId);
			writer.WriteByte(this.jobLevel);
			writer.WriteBoolean(this.free);
			writer.WriteByte(this.minLevel);
		}
	}
}