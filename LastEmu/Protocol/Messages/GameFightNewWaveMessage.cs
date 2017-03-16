using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightNewWaveMessage : NetworkMessage
	{
		public const uint Id = 6490;

		public sbyte id;

		public sbyte teamId;

		public short nbTurnBeforeNextWave;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6490;
			}
		}

		public GameFightNewWaveMessage()
		{
		}

		public GameFightNewWaveMessage(sbyte id, sbyte teamId, short nbTurnBeforeNextWave)
		{
			this.id = id;
			this.teamId = teamId;
			this.nbTurnBeforeNextWave = nbTurnBeforeNextWave;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadSByte();
			this.teamId = reader.ReadSByte();
			this.nbTurnBeforeNextWave = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.id);
			writer.WriteSByte(this.teamId);
			writer.WriteShort(this.nbTurnBeforeNextWave);
		}
	}
}