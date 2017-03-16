using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TaxCollectorLootInformations : TaxCollectorComplementaryInformations
	{
		public const short Id = 372;

		public uint kamas;

		public double experience;

		public uint pods;

		public uint itemsValue;

		public override short TypeId
		{
			get
			{
				return 372;
			}
		}

		public TaxCollectorLootInformations()
		{
		}

		public TaxCollectorLootInformations(uint kamas, double experience, uint pods, uint itemsValue)
		{
			this.kamas = kamas;
			this.experience = experience;
			this.pods = pods;
			this.itemsValue = itemsValue;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.kamas = reader.ReadVarUhInt();
			this.experience = reader.ReadVarUhLong();
			this.pods = reader.ReadVarUhInt();
			this.itemsValue = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.kamas);
			writer.WriteVarLong(this.experience);
			writer.WriteVarInt((int)this.pods);
			writer.WriteVarInt((int)this.itemsValue);
		}
	}
}