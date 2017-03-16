using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class ObjectItemNotInContainer : Item
	{
		public const short Id = 134;

		public uint objectGID;

		public ObjectEffect[] effects;

		public uint objectUID;

		public uint quantity;

		public override short TypeId
		{
			get
			{
				return 134;
			}
		}

		public ObjectItemNotInContainer()
		{
		}

		public ObjectItemNotInContainer(uint objectGID, ObjectEffect[] effects, uint objectUID, uint quantity)
		{
			this.objectGID = objectGID;
			this.effects = effects;
			this.objectUID = objectUID;
			this.quantity = quantity;
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
		}
	}
}