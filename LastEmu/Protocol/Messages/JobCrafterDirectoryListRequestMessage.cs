using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class JobCrafterDirectoryListRequestMessage : NetworkMessage
	{
		public const uint Id = 6047;

		public sbyte jobId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6047;
			}
		}

		public JobCrafterDirectoryListRequestMessage()
		{
		}

		public JobCrafterDirectoryListRequestMessage(sbyte jobId)
		{
			this.jobId = jobId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.jobId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.jobId);
		}
	}
}