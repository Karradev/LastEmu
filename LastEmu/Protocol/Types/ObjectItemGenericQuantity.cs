using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectItemGenericQuantity : Item
	{
		public const short Id = 483;

		public uint objectGID;

		public uint quantity;

		public override short TypeId
		{
			get
			{
				return 483;
			}
		}

		public ObjectItemGenericQuantity()
		{
		}

		public ObjectItemGenericQuantity(uint objectGID, uint quantity)
		{
			this.objectGID = objectGID;
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.objectGID = reader.ReadVarUhShort();
			this.quantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.objectGID);
			writer.WriteVarInt((int)this.quantity);
		}
	}
}