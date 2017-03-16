using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class JobCrafterDirectorySettings
	{
		public const short Id = 97;

		public sbyte jobId;

		public byte minLevel;

		public bool free;

		public virtual short TypeId
		{
			get
			{
				return 97;
			}
		}

		public JobCrafterDirectorySettings()
		{
		}

		public JobCrafterDirectorySettings(sbyte jobId, byte minLevel, bool free)
		{
			this.jobId = jobId;
			this.minLevel = minLevel;
			this.free = free;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.jobId = reader.ReadSByte();
			this.minLevel = reader.ReadByte();
			this.free = reader.ReadBoolean();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.jobId);
			writer.WriteByte(this.minLevel);
			writer.WriteBoolean(this.free);
		}
	}
}