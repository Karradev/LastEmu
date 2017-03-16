using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeLeaveMessage : LeaveDialogMessage
	{
		public const uint Id = 5628;

		public bool success;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5628;
			}
		}

		public ExchangeLeaveMessage()
		{
		}

		public ExchangeLeaveMessage(sbyte dialogType, bool success) : base(dialogType)
		{
			this.success = success;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.success = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(this.success);
		}
	}
}