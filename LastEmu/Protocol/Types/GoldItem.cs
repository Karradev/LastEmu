using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GoldItem : Item
	{
		public const short Id = 123;

		public uint sum;

		public override short TypeId
		{
			get
			{
				return 123;
			}
		}

		public GoldItem()
		{
		}

		public GoldItem(uint sum)
		{
			this.sum = sum;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.sum = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.sum);
		}
	}
}