using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class IdentificationFailedBannedMessage : IdentificationFailedMessage
	{
		public const uint Id = 6174;

		public double banEndDate;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6174;
			}
		}

		public IdentificationFailedBannedMessage()
		{
		}

		public IdentificationFailedBannedMessage(sbyte reason, double banEndDate) : base(reason)
		{
			this.banEndDate = banEndDate;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.banEndDate = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.banEndDate);
		}
	}
}