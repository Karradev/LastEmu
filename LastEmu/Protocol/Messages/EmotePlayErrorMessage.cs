using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EmotePlayErrorMessage : NetworkMessage
	{
		public const uint Id = 5688;

		public byte emoteId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5688;
			}
		}

		public EmotePlayErrorMessage()
		{
		}

		public EmotePlayErrorMessage(byte emoteId)
		{
			this.emoteId = emoteId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.emoteId = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteByte(this.emoteId);
		}
	}
}