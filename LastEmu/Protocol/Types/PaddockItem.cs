using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PaddockItem : ObjectItemInRolePlay
	{
		public const short Id = 185;

		public ItemDurability durability;

		public override short TypeId
		{
			get
			{
				return 185;
			}
		}

		public PaddockItem()
		{
		}

		public PaddockItem(uint cellId, uint objectGID, ItemDurability durability) : base(cellId, objectGID)
		{
			this.durability = durability;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.durability = new ItemDurability();
			this.durability.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.durability.Serialize(writer);
		}
	}
}