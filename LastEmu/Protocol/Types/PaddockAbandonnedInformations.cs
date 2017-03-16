using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PaddockAbandonnedInformations : PaddockBuyableInformations
	{
		public const short Id = 133;

		public int guildId;

		public override short TypeId
		{
			get
			{
				return 133;
			}
		}

		public PaddockAbandonnedInformations()
		{
		}

		public PaddockAbandonnedInformations(uint maxOutdoorMount, uint maxItems, uint price, bool locked, int guildId) : base(maxOutdoorMount, maxItems, price, locked)
		{
			this.guildId = guildId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.guildId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.guildId);
		}
	}
}