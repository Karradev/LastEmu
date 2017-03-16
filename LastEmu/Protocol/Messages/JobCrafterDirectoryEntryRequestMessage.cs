using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class JobCrafterDirectoryEntryRequestMessage : NetworkMessage
	{
		public const uint Id = 6043;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6043;
			}
		}

		public JobCrafterDirectoryEntryRequestMessage()
		{
		}

		public JobCrafterDirectoryEntryRequestMessage(double playerId)
		{
			this.playerId = playerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.playerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.playerId);
		}
	}
}