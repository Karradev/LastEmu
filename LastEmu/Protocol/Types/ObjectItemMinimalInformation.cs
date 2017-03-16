using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class ObjectItemMinimalInformation : Item
	{
		public const short Id = 124;

		public uint objectGID;

		public ObjectEffect[] effects;

		public override short TypeId
		{
			get
			{
				return 124;
			}
		}

		public ObjectItemMinimalInformation()
		{
		}

		public ObjectItemMinimalInformation(uint objectGID, ObjectEffect[] effects)
		{
			this.objectGID = objectGID;
			this.effects = effects;
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
		}
	}
}