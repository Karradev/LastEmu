using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class CharacterStatsListMessage : NetworkMessage
	{
		public const uint Id = 500;

		public CharacterCharacteristicsInformations stats;

		public override uint ProtocolId
		{
			get
			{
				return (uint)500;
			}
		}

		public CharacterStatsListMessage()
		{
		}

		public CharacterStatsListMessage(CharacterCharacteristicsInformations stats)
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