using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AlmanachCalendarDateMessage : NetworkMessage
	{
		public const uint Id = 6341;

		public int date;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6341;
			}
		}

		public AlmanachCalendarDateMessage()
		{
		}

		public AlmanachCalendarDateMessage(int date)
		{
			this.date = date;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.date = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.date);
		}
	}
}