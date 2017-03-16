using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class JobCrafterDirectoryRemoveMessage : NetworkMessage
	{
		public const uint Id = 5653;

		public sbyte jobId;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5653;
			}
		}

		public JobCrafterDirectoryRemoveMessage()
		{
		}

		public JobCrafterDirectoryRemoveMessage(sbyte jobId, double playerId)
		{
			this.jobId = jobId;
			this.playerId = playerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.jobId = reader.ReadSByte();
			this.playerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.jobId);
			writer.WriteVarLong(this.playerId);
		}
	}
}