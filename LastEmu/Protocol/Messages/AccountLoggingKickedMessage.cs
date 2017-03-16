using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AccountLoggingKickedMessage : NetworkMessage
	{
		public const uint Id = 6029;

		public uint days;

		public sbyte hours;

		public sbyte minutes;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6029;
			}
		}

		public AccountLoggingKickedMessage()
		{
		}

		public AccountLoggingKickedMessage(uint days, sbyte hours, sbyte minutes)
		{
			this.days = days;
			this.hours = hours;
			this.minutes = minutes;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.days = reader.ReadVarUhShort();
			this.hours = reader.ReadSByte();
			this.minutes = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.days);
			writer.WriteSByte(this.hours);
			writer.WriteSByte(this.minutes);
		}
	}
}