using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EmotePlayAbstractMessage : NetworkMessage
	{
		public const uint Id = 5690;

		public byte emoteId;

		public double emoteStartTime;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5690;
			}
		}

		public EmotePlayAbstractMessage()
		{
		}

		public EmotePlayAbstractMessage(byte emoteId, double emoteStartTime)
		{
			this.emoteId = emoteId;
			this.emoteStartTime = emoteStartTime;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.emoteId = reader.ReadByte();
			this.emoteStartTime = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteByte(this.emoteId);
			writer.WriteDouble(this.emoteStartTime);
		}
	}
}