using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class OnConnectionEventMessage : NetworkMessage
	{
		public const uint Id = 5726;

		public sbyte eventType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5726;
			}
		}

		public OnConnectionEventMessage()
		{
		}

		public OnConnectionEventMessage(sbyte eventType)
		{
			this.eventType = eventType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.eventType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.eventType);
		}
	}
}