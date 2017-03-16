using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HouseInformationsExtended : HouseInformations
	{
		public const short Id = 112;

		public GuildInformations guildInfo;

		public override short TypeId
		{
			get
			{
				return 112;
			}
		}

		public HouseInformationsExtended()
		{
		}

		public HouseInformationsExtended(bool isOnSale, bool isSaleLocked, uint houseId, int[] doorsOnMap, string ownerName, uint modelId, GuildInformations guildInfo) : base(isOnSale, isSaleLocked, houseId, doorsOnMap, ownerName, modelId)
		{
			this.guildInfo = guildInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.guildInfo = new GuildInformations();
			this.guildInfo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.guildInfo.Serialize(writer);
		}
	}
}