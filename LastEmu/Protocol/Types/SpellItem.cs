using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class SpellItem : Item
	{
		public const short Id = 49;

		public int spellId;

		public short spellLevel;

		public override short TypeId
		{
			get
			{
				return 49;
			}
		}

		public SpellItem()
		{
		}

		public SpellItem(int spellId, short spellLevel)
		{
			this.spellId = spellId;
			this.spellLevel = spellLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.spellId = reader.ReadInt();
			this.spellLevel = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.spellId);
			writer.WriteShort(this.spellLevel);
		}
	}
}