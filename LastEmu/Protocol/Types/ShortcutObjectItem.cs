using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ShortcutObjectItem : ShortcutObject
	{
		public const short Id = 371;

		public int itemUID;

		public int itemGID;

		public override short TypeId
		{
			get
			{
				return 371;
			}
		}

		public ShortcutObjectItem()
		{
		}

		public ShortcutObjectItem(sbyte slot, int itemUID, int itemGID) : base(slot)
		{
			this.itemUID = itemUID;
			this.itemGID = itemGID;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.itemUID = reader.ReadInt();
			this.itemGID = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.itemUID);
			writer.WriteInt(this.itemGID);
		}
	}
}