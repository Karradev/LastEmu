using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectItemInformationWithQuantity : ObjectItemMinimalInformation
	{
		public const short Id = 387;

		public uint quantity;

		public override short TypeId
		{
			get
			{
				return 387;
			}
		}

		public ObjectItemInformationWithQuantity()
		{
		}

		public ObjectItemInformationWithQuantity(uint objectGID, ObjectEffect[] effects, uint quantity) : base(objectGID, effects)
		{
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.quantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.quantity);
		}
	}
}