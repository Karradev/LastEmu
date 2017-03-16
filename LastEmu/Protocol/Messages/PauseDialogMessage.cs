using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PauseDialogMessage : NetworkMessage
	{
		public const uint Id = 6012;

		public sbyte dialogType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6012;
			}
		}

		public PauseDialogMessage()
		{
		}

		public PauseDialogMessage(sbyte dialogType)
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