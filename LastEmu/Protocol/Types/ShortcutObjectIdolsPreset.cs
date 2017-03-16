using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ShortcutObjectIdolsPreset : ShortcutObject
	{
		public const short Id = 492;

		public sbyte presetId;

		public override short TypeId
		{
			get
			{
				return 492;
			}
		}

		public ShortcutObjectIdolsPreset()
		{
		}

		public ShortcutObjectIdolsPreset(sbyte slot, sbyte presetId) : base(slot)
		{
			this.presetId = presetId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.presetId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.presetId);
		}
	}
}