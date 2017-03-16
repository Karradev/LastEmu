using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ShortcutObjectPreset : ShortcutObject
	{
		public const short Id = 370;

		public sbyte presetId;

		public override short TypeId
		{
			get
			{
				return 370;
			}
		}

		public ShortcutObjectPreset()
		{
		}

		public ShortcutObjectPreset(sbyte slot, sbyte presetId) : base(slot)
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