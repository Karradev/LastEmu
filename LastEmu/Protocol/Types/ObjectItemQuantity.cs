using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectItemQuantity : Item
	{
		public const short Id = 119;

		public uint objectUID;

		public uint quantity;

		public override short TypeId
		{
			get
			{
				return 119;
			}
		}

		public ObjectItemQuantity()
		{
		}

		public ObjectItemQuantity(uint objectUID, uint quantity)
		{
			this.objectUID = objectUID;
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.objectUID = reader.ReadVarUhInt();
			this.quantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.objectUID);
			writer.WriteVarInt((int)this.quantity);
		}
	}
}