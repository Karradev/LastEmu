using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class KrosmasterPlayingStatusMessage : NetworkMessage
	{
		public const uint Id = 6347;

		public bool playing;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6347;
			}
		}

		public KrosmasterPlayingStatusMessage()
		{
		}

		public KrosmasterPlayingStatusMessage(bool playing)
		{
			this.playing = playing;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.playing = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.playing);
		}
	}
}