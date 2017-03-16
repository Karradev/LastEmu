using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class IndexedEntityLook
	{
		public const short Id = 405;

		public EntityLook look;

		public sbyte index;

		public virtual short TypeId
		{
			get
			{
				return 405;
			}
		}

		public IndexedEntityLook()
		{
		}

		public IndexedEntityLook(EntityLook look, sbyte index)
		{
			this.look = look;
			this.index = index;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.look = new EntityLook();
			this.look.Deserialize(reader);
			this.index = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			this.look.Serialize(writer);
			writer.WriteSByte(this.index);
		}
	}
}