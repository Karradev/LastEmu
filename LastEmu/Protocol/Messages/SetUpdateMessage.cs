using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class SetUpdateMessage : NetworkMessage
	{
		public const uint Id = 5503;

		public uint setId;

		public uint[] setObjects;

		public ObjectEffect[] setEffects;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5503;
			}
		}

		public SetUpdateMessage()
		{
		}

		public SetUpdateMessage(uint setId, uint[] setObjects, ObjectEffect[] setEffects)
		{
			this.setId = setId;
			this.setObjects = setObjects;
			this.setEffects = setEffects;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.setId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.setObjects = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.setObjects[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.setEffects = new ObjectEffect[num];
			for (int j = 0; j < num; j++)
			{
				this.setEffects[j] = ProtocolTypeManager.GetInstance<ObjectEffect>(reader.ReadUShort());
				this.setEffects[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.setId);
			writer.WriteShort((short)((int)this.setObjects.Length));
			uint[] numArray = this.setObjects;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.setEffects.Length));
			ObjectEffect[] objectEffectArray = this.setEffects;
			for (int j = 0; j < (int)objectEffectArray.Length; j++)
			{
				ObjectEffect objectEffect = objectEffectArray[j];
				writer.WriteShort(objectEffect.TypeId);
				objectEffect.Serialize(writer);
			}
		}
	}
}