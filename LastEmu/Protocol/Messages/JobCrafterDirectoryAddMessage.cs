using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class JobCrafterDirectoryAddMessage : NetworkMessage
	{
		public const uint Id = 5651;

		public JobCrafterDirectoryListEntry listEntry;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5651;
			}
		}

		public JobCrafterDirectoryAddMessage()
		{
		}

		public JobCrafterDirectoryAddMessage(JobCrafterDirectoryListEntry listEntry)
		{
			this.listEntry = listEntry;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.listEntry = new JobCrafterDirectoryListEntry();
			this.listEntry.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.listEntry.Serialize(writer);
		}
	}
}