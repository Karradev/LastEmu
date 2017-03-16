using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightHumanReadyStateMessage : NetworkMessage
	{
		public const uint Id = 740;

		public double characterId;

		public bool isReady;

		public override uint ProtocolId
		{
			get
			{
				return (uint)740;
			}
		}

		public GameFightHumanReadyStateMessage()
		{
		}

		public GameFightHumanReadyStateMessage(double characterId, bool isReady)
		{
			this.characterId = characterId;
			this.isReady = isReady;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.characterId = reader.ReadVarUhLong();
			this.isReady = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.characterId);
			writer.WriteBoolean(this.isReady);
		}
	}
}