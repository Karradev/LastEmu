using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ShortcutObject : Shortcut
	{
		public const short Id = 367;

		public override short TypeId
		{
			get
			{
				return 367;
			}
		}

		public ShortcutObject()
		{
		}

		public ShortcutObject(sbyte slot) : base(slot)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}