using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class RefreshCharacterStatsMessage : NetworkMessage
	{
		public const uint Id = 6699;

		public double fighterId;

		public GameFightMinimalStats stats;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6699;
			}
		}

		public RefreshCharacterStatsMessage()
		{
		}

		public RefreshCharacterStatsMessage(double fighterId, GameFightMinimalStats stats)
		{
			this.fighterId = fighterId;
			this.stats = stats;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fighterId = reader.ReadDouble();
			this.stats = new GameFightMinimalStats();
			this.stats.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.fighterId);
			this.stats.Serialize(writer);
		}
	}
}