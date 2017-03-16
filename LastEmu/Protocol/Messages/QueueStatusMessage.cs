using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class QueueStatusMessage : NetworkMessage
	{
		public const uint Id = 6100;

		public ushort position;

		public ushort total;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6100;
			}
		}

		public QueueStatusMessage()
		{
		}

		public QueueStatusMessage(ushort position, ushort total)
		{
			this.position = position;
			this.total = total;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.position = reader.ReadUShort();
			this.total = reader.ReadUShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort(this.position);
			writer.WriteUShort(this.total);
		}
	}
}