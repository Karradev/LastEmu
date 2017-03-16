using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicTimeMessage : NetworkMessage
	{
		public const uint Id = 175;

		public double timestamp;

		public short timezoneOffset;

		public override uint ProtocolId
		{
			get
			{
				return (uint)175;
			}
		}

		public BasicTimeMessage()
		{
		}

		public BasicTimeMessage(double timestamp, short timezoneOffset)
		{
			this.timestamp = timestamp;
			this.timezoneOffset = timezoneOffset;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.timestamp = reader.ReadDouble();
			this.timezoneOffset = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.timestamp);
			writer.WriteShort(this.timezoneOffset);
		}
	}
}