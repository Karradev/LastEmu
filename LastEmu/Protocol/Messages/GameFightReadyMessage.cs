using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightReadyMessage : NetworkMessage
	{
		public const uint Id = 708;

		public bool isReady;

		public override uint ProtocolId
		{
			get
			{
				return (uint)708;
			}
		}

		public GameFightReadyMessage()
		{
		}

		public GameFightReadyMessage(bool isReady)
		{
			this.isReady = isReady;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.isReady = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.isReady);
		}
	}
}