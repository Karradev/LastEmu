using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildHousesInformationMessage : NetworkMessage
	{
		public const uint Id = 5919;

		public HouseInformationsForGuild[] housesInformations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5919;
			}
		}

		public GuildHousesInformationMessage()
		{
		}

		public GuildHousesInformationMessage(HouseInformationsForGuild[] housesInformations)
		{
			this.housesInformations = housesInformations;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.housesInformations = new HouseInformationsForGuild[num];
			for (int i = 0; i < num; i++)
			{
				this.housesInformations[i] = new HouseInformationsForGuild();
				this.housesInformations[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.housesInformations.Length));
			HouseInformationsForGuild[] houseInformationsForGuildArray = this.housesInformations;
			for (int i = 0; i < (int)houseInformationsForGuildArray.Length; i++)
			{
				houseInformationsForGuildArray[i].Serialize(writer);
			}
		}
	}
}