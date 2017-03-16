using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class BidExchangerObjectInfo
	{
		public const short Id = 122;

		public uint objectUID;

		public ObjectEffect[] effects;

		public int[] prices;

		public virtual short TypeId
		{
			get
			{
				return 122;
			}
		}

		public BidExchangerObjectInfo()
		{
		}

		public BidExchangerObjectInfo(uint objectUID, ObjectEffect[] effects, int[] prices)
		{
			this.objectUID = objectUID;
			this.effects = effects;
			this.prices = prices;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.objectUID = reader.ReadVarUhInt();
			ushort num = reader.ReadUShort();
			this.effects = new ObjectEffect[num];
			for (int i = 0; i < num; i++)
			{
				this.effects[i] = ProtocolTypeManager.GetInstance<ObjectEffect>(reader.ReadUShort());
				this.effects[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.prices = new int[num];
			for (int j = 0; j < num; j++)
			{
				this.prices[j] = reader.ReadInt();
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.objectUID);
			writer.WriteShort((short)((int)this.effects.Length));
			ObjectEffect[] objectEffectArray = this.effects;
			for (int i = 0; i < (int)objectEffectArray.Length; i++)
			{
				ObjectEffect objectEffect = objectEffectArray[i];
				writer.WriteShort(objectEffect.TypeId);
				objectEffect.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.prices.Length));
			int[] numArray = this.prices;
			for (int j = 0; j < (int)numArray.Length; j++)
			{
				writer.WriteInt(numArray[j]);
			}
		}
	}
}