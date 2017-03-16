using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterReportMessage : NetworkMessage
	{
		public const uint Id = 6079;

		public double reportedId;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6079;
			}
		}

		public CharacterReportMessage()
		{
		}

		public CharacterReportMessage(double reportedId, sbyte reason)
		{
			this.reportedId = reportedId;
			this.reason = reason;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.reportedId = reader.ReadVarUhLong();
			this.reason = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.reportedId);
			writer.WriteSByte(this.reason);
		}
	}
}