using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ObjectsQuantityMessage : NetworkMessage
	{
		public const uint Id = 6206;

		public ObjectItemQuantity[] objectsUIDAndQty;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6206;
			}
		}

		public ObjectsQuantityMessage()
		{
		}

		public ObjectsQuantityMessage(ObjectItemQuantity[] objectsUIDAndQty)
		{
			this.objectsUIDAndQty = objectsUIDAndQty;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.objectsUIDAndQty = new ObjectItemQuantity[num];
			for (int i = 0; i < num; i++)
			{
				this.objectsUIDAndQty[i] = new ObjectItemQuantity();
				this.objectsUIDAndQty[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.objectsUIDAndQty.Length));
			ObjectItemQuantity[] objectItemQuantityArray = this.objectsUIDAndQty;
			for (int i = 0; i < (int)objectItemQuantityArray.Length; i++)
			{
				objectItemQuantityArray[i].Serialize(writer);
			}
		}
	}
}