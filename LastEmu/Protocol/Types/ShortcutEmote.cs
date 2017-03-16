using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ShortcutEmote : Shortcut
	{
		public const short Id = 389;

		public byte emoteId;

		public override short TypeId
		{
			get
			{
				return 389;
			}
		}

		public ShortcutEmote()
		{
		}

		public ShortcutEmote(sbyte slot, byte emoteId) : base(slot)
		{
			this.emoteId = emoteId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.emoteId = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(this.emoteId);
		}
	}
}