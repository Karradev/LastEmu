using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectItemToSellInNpcShop : ObjectItemMinimalInformation
	{
		public const short Id = 352;

		public uint objectPrice;

		public string buyCriterion;

		public override short TypeId
		{
			get
			{
				return 352;
			}
		}

		public ObjectItemToSellInNpcShop()
		{
		}

		public ObjectItemToSellInNpcShop(uint objectGID, ObjectEffect[] effects, uint objectPrice, string buyCriterion) : base(objectGID, effects)
		{
			this.objectPrice = objectPrice;
			this.buyCriterion = buyCriterion;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.objectPrice = reader.ReadVarUhInt();
			this.buyCriterion = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.objectPrice);
			writer.WriteUTF(this.buyCriterion);
		}
	}
}