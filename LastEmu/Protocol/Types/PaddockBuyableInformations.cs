using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PaddockBuyableInformations : PaddockInformations
	{
		public const short Id = 130;

		public uint price;

		public bool locked;

		public override short TypeId
		{
			get
			{
				return 130;
			}
		}

		public PaddockBuyableInformations()
		{
		}

		public PaddockBuyableInformations(uint maxOutdoorMount, uint maxItems, uint price, bool locked) : base(maxOutdoorMount, maxItems)
		{
			this.price = price;
			this.locked = locked;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.price = reader.ReadVarUhInt();
			this.locked = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.price);
			writer.WriteBoolean(this.locked);
		}
	}
}