using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class EntityDispositionInformations
	{
		public const short Id = 60;

		public short cellId;

		public sbyte direction;

		public virtual short TypeId
		{
			get
			{
				return 60;
			}
		}

		public EntityDispositionInformations()
		{
		}

		public EntityDispositionInformations(short cellId, sbyte direction)
		{
			this.cellId = cellId;
			this.direction = direction;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.cellId = reader.ReadShort();
			this.direction = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.cellId);
			writer.WriteSByte(this.direction);
		}
	}
}