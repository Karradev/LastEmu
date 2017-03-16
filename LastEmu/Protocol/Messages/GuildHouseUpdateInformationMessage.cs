using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildHouseUpdateInformationMessage : NetworkMessage
	{
		public const uint Id = 6181;

		public HouseInformationsForGuild housesInformations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6181;
			}
		}

		public GuildHouseUpdateInformationMessage()
		{
		}

		public GuildHouseUpdateInformationMessage(HouseInformationsForGuild housesInformations)
		{
			this.housesInformations = housesInformations;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.housesInformations = new HouseInformationsForGuild();
			this.housesInformations.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.housesInformations.Serialize(writer);
		}
	}
}