using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CurrentServerStatusUpdateMessage : NetworkMessage
	{
		public const uint Id = 6525;

		public sbyte status;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6525;
			}
		}

		public CurrentServerStatusUpdateMessage()
		{
		}

		public CurrentServerStatusUpdateMessage(sbyte status)
		{
			this.status = status;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.status = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.status);
		}
	}
}