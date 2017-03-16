using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class Shortcut
	{
		public const short Id = 369;

		public sbyte slot;

		public virtual short TypeId
		{
			get
			{
				return 369;
			}
		}

		public Shortcut()
		{
		}

		public Shortcut(sbyte slot)
		{
			this.slot = slot;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.slot = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.slot);
		}
	}
}