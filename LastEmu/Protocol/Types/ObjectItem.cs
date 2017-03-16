using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class ObjectItem : Item
	{
		public const short Id = 37;

		public byte position;

		public uint objectGID;

		public ObjectEffect[] effects;

		public uint objectUID;

		public uint quantity;

		public override short TypeId
		{
			get
			{
				return 37;
			}
		}

		public ObjectItem()
		{
		}

		public ObjectItem(byte position, uint objectGID, ObjectEffect[] effects, uint objectUID, uint quantity)
		{
			this.position = position;
			this.objectGID = objectGID;
			this.effects = effects;
			this.objectUID = objectUID;
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.position = reader.ReadByte();
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
			writer.WriteByte(this.position);
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