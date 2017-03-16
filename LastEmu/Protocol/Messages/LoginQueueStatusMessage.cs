using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LoginQueueStatusMessage : NetworkMessage
	{
		public const uint Id = 10;

		public ushort position;

		public ushort total;

		public override uint ProtocolId
		{
			get
			{
				return (uint)10;
			}
		}

		public LoginQueueStatusMessage()
		{
		}

		public LoginQueueStatusMessage(ushort position, ushort total)
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