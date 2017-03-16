using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class Idol
	{
		public const short Id = 489;

		public uint id;

		public uint xpBonusPercent;

		public uint dropBonusPercent;

		public virtual short TypeId
		{
			get
			{
				return 489;
			}
		}

		public Idol()
		{
		}

		public Idol(uint id, uint xpBonusPercent, uint dropBonusPercent)
		{
			this.id = id;
			this.xpBonusPercent = xpBonusPercent;
			this.dropBonusPercent = dropBonusPercent;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhShort();
			this.xpBonusPercent = reader.ReadVarUhShort();
			this.dropBonusPercent = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.id);
			writer.WriteVarShort((int)this.xpBonusPercent);
			writer.WriteVarShort((int)this.dropBonusPercent);
		}
	}
}