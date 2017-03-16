using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NicknameRefusedMessage : NetworkMessage
	{
		public const uint Id = 5638;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5638;
			}
		}

		public NicknameRefusedMessage()
		{
		}

		public NicknameRefusedMessage(sbyte reason)
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