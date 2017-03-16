using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ShortcutSpell : Shortcut
	{
		public const short Id = 368;

		public uint spellId;

		public override short TypeId
		{
			get
			{
				return 368;
			}
		}

		public ShortcutSpell()
		{
		}

		public ShortcutSpell(sbyte slot, uint spellId) : base(slot)
		{
			this.spellId = spellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.spellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.spellId);
		}
	}
}