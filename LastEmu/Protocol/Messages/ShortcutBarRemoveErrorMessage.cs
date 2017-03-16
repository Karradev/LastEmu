using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ShortcutBarRemoveErrorMessage : NetworkMessage
	{
		public const uint Id = 6222;

		public sbyte error;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6222;
			}
		}

		public ShortcutBarRemoveErrorMessage()
		{
		}

		public ShortcutBarRemoveErrorMessage(sbyte error)
		{
			this.error = error;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.error = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.error);
		}
	}
}