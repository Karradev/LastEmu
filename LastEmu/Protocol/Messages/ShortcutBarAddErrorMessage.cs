using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ShortcutBarAddErrorMessage : NetworkMessage
	{
		public const uint Id = 6227;

		public sbyte error;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6227;
			}
		}

		public ShortcutBarAddErrorMessage()
		{
		}

		public ShortcutBarAddErrorMessage(sbyte error)
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