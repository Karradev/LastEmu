using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ShortcutBarSwapErrorMessage : NetworkMessage
	{
		public const uint Id = 6226;

		public sbyte error;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6226;
			}
		}

		public ShortcutBarSwapErrorMessage()
		{
		}

		public ShortcutBarSwapErrorMessage(sbyte error)
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