using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ItemDurability
	{
		public const short Id = 168;

		public short durability;

		public short durabilityMax;

		public virtual short TypeId
		{
			get
			{
				return 168;
			}
		}

		public ItemDurability()
		{
		}

		public ItemDurability(short durability, short durabilityMax)
		{
			this.durability = durability;
			this.durabilityMax = durabilityMax;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.durability = reader.ReadShort();
			this.durabilityMax = reader.ReadShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.durability);
			writer.WriteShort(this.durabilityMax);
		}
	}
}