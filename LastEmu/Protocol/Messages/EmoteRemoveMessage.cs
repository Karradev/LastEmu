using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EmoteRemoveMessage : NetworkMessage
	{
		public const uint Id = 5687;

		public byte emoteId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5687;
			}
		}

		public EmoteRemoveMessage()
		{
		}

		public EmoteRemoveMessage(byte emoteId)
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