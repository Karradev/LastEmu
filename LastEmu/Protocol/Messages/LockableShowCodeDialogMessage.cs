using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LockableShowCodeDialogMessage : NetworkMessage
	{
		public const uint Id = 5740;

		public bool changeOrUse;

		public sbyte codeSize;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5740;
			}
		}

		public LockableShowCodeDialogMessage()
		{
		}

		public LockableShowCodeDialogMessage(bool changeOrUse, sbyte codeSize)
		{
			this.changeOrUse = changeOrUse;
			this.codeSize = codeSize;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.changeOrUse = reader.ReadBoolean();
			this.codeSize = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.changeOrUse);
			writer.WriteSByte(this.codeSize);
		}
	}
}