using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HumanOptionFollowers : HumanOption
	{
		public const short Id = 410;

		public IndexedEntityLook[] followingCharactersLook;

		public override short TypeId
		{
			get
			{
				return 410;
			}
		}

		public HumanOptionFollowers()
		{
		}

		public HumanOptionFollowers(IndexedEntityLook[] followingCharactersLook)
		{
			this.followingCharactersLook = followingCharactersLook;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.followingCharactersLook = new IndexedEntityLook[num];
			for (int i = 0; i < num; i++)
			{
				this.followingCharactersLook[i] = new IndexedEntityLook();
				this.followingCharactersLook[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.followingCharactersLook.Length));
			IndexedEntityLook[] indexedEntityLookArray = this.followingCharactersLook;
			for (int i = 0; i < (int)indexedEntityLookArray.Length; i++)
			{
				indexedEntityLookArray[i].Serialize(writer);
			}
		}
	}
}