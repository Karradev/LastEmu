using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightTurnReadyMessage : NetworkMessage
	{
		public const uint Id = 716;

		public bool isReady;

		public override uint ProtocolId
		{
			get
			{
				return (uint)716;
			}
		}

		public GameFightTurnReadyMessage()
		{
		}

		public GameFightTurnReadyMessage(bool isReady)
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