using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectItemGenericQuantityPrice : ObjectItemGenericQuantity
	{
		public const short Id = 494;

		public uint price;

		public override short TypeId
		{
			get
			{
				return 494;
			}
		}

		public ObjectItemGenericQuantityPrice()
		{
		}

		public ObjectItemGenericQuantityPrice(uint objectGID, uint quantity, uint price) : base(objectGID, quantity)
		{
			this.price = price;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.price = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.price);
		}
	}
}