using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class UpdateMountBoost
	{
		public const short Id = 356;

		public sbyte type;

		public virtual short TypeId
		{
			get
			{
				return 356;
			}
		}

		public UpdateMountBoost()
		{
		}

		public UpdateMountBoost(sbyte type)
		{
			this.type = type;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.type = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.type);
		}
	}
}