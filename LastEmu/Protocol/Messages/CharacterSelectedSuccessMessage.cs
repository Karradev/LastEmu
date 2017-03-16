using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class CharacterSelectedSuccessMessage : NetworkMessage
	{
		public const uint Id = 153;

		public CharacterBaseInformations infos;

		public bool isCollectingStats;

		public override uint ProtocolId
		{
			get
			{
				return (uint)153;
			}
		}

		public CharacterSelectedSuccessMessage()
		{
		}

		public CharacterSelectedSuccessMessage(CharacterBaseInformations infos, bool isCollectingStats)
		{
			this.infos = infos;
			this.isCollectingStats = isCollectingStats;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.infos = new CharacterBaseInformations();
			this.infos.Deserialize(reader);
			this.isCollectingStats = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			this.infos.Serialize(writer);
			writer.WriteBoolean(this.isCollectingStats);
		}
	}
}