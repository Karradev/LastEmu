using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class SubEntity
	{
		public const short Id = 54;

		public sbyte bindingPointCategory;

		public sbyte bindingPointIndex;

		public EntityLook subEntityLook;

		public virtual short TypeId
		{
			get
			{
				return 54;
			}
		}

		public SubEntity()
		{
		}

		public SubEntity(sbyte bindingPointCategory, sbyte bindingPointIndex, EntityLook subEntityLook)
		{
			this.bindingPointCategory = bindingPointCategory;
			this.bindingPointIndex = bindingPointIndex;
			this.subEntityLook = subEntityLook;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.bindingPointCategory = reader.ReadSByte();
			this.bindingPointIndex = reader.ReadSByte();
			this.subEntityLook = new EntityLook();
			this.subEntityLook.Deserialize(reader);
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.bindingPointCategory);
			writer.WriteSByte(this.bindingPointIndex);
			this.subEntityLook.Serialize(writer);
		}
	}
}