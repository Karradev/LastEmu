using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChatErrorMessage : NetworkMessage
	{
		public const uint Id = 870;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)870;
			}
		}

		public ChatErrorMessage()
		{
		}

		public ChatErrorMessage(sbyte reason)
		{
			this.reason = reason;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.reason = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.reason);
		}
	}
}