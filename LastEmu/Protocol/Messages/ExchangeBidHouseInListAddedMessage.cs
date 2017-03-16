using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeBidHouseInListAddedMessage : NetworkMessage
	{
		public const uint Id = 5949;

		public int itemUID;

		public int objGenericId;

		public ObjectEffect[] effects;

		public uint[] prices;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5949;
			}
		}

		public ExchangeBidHouseInListAddedMessage()
		{
		}

		public ExchangeBidHouseInListAddedMessage(int itemUID, int objGenericId, ObjectEffect[] effects, uint[] prices)
		{
			this.itemUID = itemUID;
			this.objGenericId = objGenericId;
			this.effects = effects;
			this.prices = prices;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.itemUID = reader.ReadInt();
			this.objGenericId = reader.ReadInt();
			ushort num = reader.ReadUShort();
			this.effects = new ObjectEffect[num];
			for (int i = 0; i < num; i++)
			{
				this.effects[i] = ProtocolTypeManager.GetInstance<ObjectEffect>(reader.ReadUShort());
				this.effects[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.prices = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.prices[j] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.itemUID);
			writer.WriteInt(this.objGenericId);
			writer.WriteShort((short)((int)this.effects.Length));
			ObjectEffect[] objectEffectArray = this.effects;
			for (int i = 0; i < (int)objectEffectArray.Length; i++)
			{
				ObjectEffect objectEffect = objectEffectArray[i];
				writer.WriteShort(objectEffect.TypeId);
				objectEffect.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.prices.Length));
			uint[] numArray = this.prices;
			for (int j = 0; j < (int)numArray.Length; j++)
			{
				writer.WriteVarInt((int)numArray[j]);
			}
		}
	}
}