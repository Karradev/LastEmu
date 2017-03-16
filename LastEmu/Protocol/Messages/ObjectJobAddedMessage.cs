using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectJobAddedMessage : NetworkMessage
	{
		public const uint Id = 6014;

		public sbyte jobId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6014;
			}
		}

		public ObjectJobAddedMessage()
		{
		}

		public ObjectJobAddedMessage(sbyte jobId)
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