using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicDateMessage : NetworkMessage
	{
		public const uint Id = 177;

		public sbyte day;

		public sbyte month;

		public short year;

		public override uint ProtocolId
		{
			get
			{
				return (uint)177;
			}
		}

		public BasicDateMessage()
		{
		}

		public BasicDateMessage(sbyte day, sbyte month, short year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.day = reader.ReadSByte();
			this.month = reader.ReadSByte();
			this.year = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.day);
			writer.WriteSByte(this.month);
			writer.WriteShort(this.year);
		}
	}
}