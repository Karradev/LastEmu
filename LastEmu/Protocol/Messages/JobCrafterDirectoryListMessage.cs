using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class JobCrafterDirectoryListMessage : NetworkMessage
	{
		public const uint Id = 6046;

		public JobCrafterDirectoryListEntry[] listEntries;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6046;
			}
		}

		public JobCrafterDirectoryListMessage()
		{
		}

		public JobCrafterDirectoryListMessage(JobCrafterDirectoryListEntry[] listEntries)
		{
			this.listEntries = listEntries;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.listEntries = new JobCrafterDirectoryListEntry[num];
			for (int i = 0; i < num; i++)
			{
				this.listEntries[i] = new JobCrafterDirectoryListEntry();
				this.listEntries[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.listEntries.Length));
			JobCrafterDirectoryListEntry[] jobCrafterDirectoryListEntryArray = this.listEntries;
			for (int i = 0; i < (int)jobCrafterDirectoryListEntryArray.Length; i++)
			{
				jobCrafterDirectoryListEntryArray[i].Serialize(writer);
			}
		}
	}
}