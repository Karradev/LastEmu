using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ShortcutSmiley : Shortcut
	{
		public const short Id = 388;

		public uint smileyId;

		public override short TypeId
		{
			get
			{
				return 388;
			}
		}

		public ShortcutSmiley()
		{
		}

		public ShortcutSmiley(sbyte slot, uint smileyId) : base(slot)
		{
			this.smileyId = smileyId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.smileyId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.smileyId);
		}
	}
}