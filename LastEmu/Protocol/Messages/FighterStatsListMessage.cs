using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class FighterStatsListMessage : NetworkMessage
	{
		public const uint Id = 6322;

		public CharacterCharacteristicsInformations stats;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6322;
			}
		}

		public FighterStatsListMessage()
		{
		}

		public FighterStatsListMessage(CharacterCharacteristicsInformations stats)
		{
			this.stats = stats;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.stats = new CharacterCharacteristicsInformations();
			this.stats.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.stats.Serialize(writer);
		}
	}
}