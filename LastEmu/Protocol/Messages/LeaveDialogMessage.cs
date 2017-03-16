using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LeaveDialogMessage : NetworkMessage
	{
		public const uint Id = 5502;

		public sbyte dialogType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5502;
			}
		}

		public LeaveDialogMessage()
		{
		}

		public LeaveDialogMessage(sbyte dialogType)
		{
			this.dialogType = dialogType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dialogType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.dialogType);
		}
	}
}