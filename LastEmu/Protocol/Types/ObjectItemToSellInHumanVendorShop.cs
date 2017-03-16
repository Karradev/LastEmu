using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class ObjectItemToSellInHumanVendorShop : Item
	{
		public const short Id = 359;

		public uint objectGID;

		public ObjectEffect[] effects;

		public uint objectUID;

		public uint quantity;

		public uint objectPrice;

		public uint publicPrice;

		public override short TypeId
		{
			get
			{
				return 359;
			}
		}

		public ObjectItemToSellInHumanVendorShop()
		{
		}

		public ObjectItemToSellInHumanVendorShop(uint objectGID, ObjectEffect[] effects, uint objectUID, uint quantity, uint objectPrice, uint publicPrice)
		{
			this.objectGID = objectGID;
			this.effects = effects;
			this.objectUID = objectUID;
			this.quantity = quantity;
			this.objectPrice = objectPrice;
			this.publicPrice = publicPrice;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.objectGID = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.effects = new ObjectEffect[num];
			for (int i = 0; i < num; i++)
			{
				this.effects[i] = ProtocolTypeManager.GetInstance<ObjectEffect>(reader.ReadUShort());
				this.effects[i].Deserialize(reader);
			}
			this.objectUID = reader.ReadVarUhInt();
			this.quantity = reader.ReadVarUhInt();
			this.objectPrice = reader.ReadVarUhInt();
			this.publicPrice = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.objectGID);
			writer.WriteShort((short)((int)this.effects.Length));
			ObjectEffect[] objectEffectArray = this.effects;
			for (int i = 0; i < (int)objectEffectArray.Length; i++)
			{
				ObjectEffect objectEffect = objectEffectArray[i];
				writer.WriteShort(objectEffect.TypeId);
				objectEffect.Serialize(writer);
			}
			writer.WriteVarInt((int)this.objectUID);
			writer.WriteVarInt((int)this.quantity);
			writer.WriteVarInt((int)this.objectPrice);
			writer.WriteVarInt((int)this.publicPrice);
		}
	}
}