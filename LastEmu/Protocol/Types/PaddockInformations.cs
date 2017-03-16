using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PaddockInformations
	{
		public const short Id = 132;

		public uint maxOutdoorMount;

		public uint maxItems;

		public virtual short TypeId
		{
			get
			{
				return 132;
			}
		}

		public PaddockInformations()
		{
		}

		public PaddockInformations(uint maxOutdoorMount, uint maxItems)
		{
			this.maxOutdoorMount = maxOutdoorMount;
			this.maxItems = maxItems;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.maxOutdoorMount = reader.ReadVarUhShort();
			this.maxItems = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.maxOutdoorMount);
			writer.WriteVarShort((int)this.maxItems);
		}
	}
}