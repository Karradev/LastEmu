using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EmoteAddMessage : NetworkMessage
	{
		public const uint Id = 5644;

		public byte emoteId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5644;
			}
		}

		public EmoteAddMessage()
		{
		}

		public EmoteAddMessage(byte emoteId)
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