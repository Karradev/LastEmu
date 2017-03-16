using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightLoot
	{
		public const short Id = 41;

		public uint[] objects;

		public uint kamas;

		public virtual short TypeId
		{
			get
			{
				return 41;
			}
		}

		public FightLoot()
		{
		}

		public FightLoot(uint[] objects, uint kamas)
		{
			this.objects = objects;
			this.kamas = kamas;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.objects = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.objects[i] = reader.ReadVarUhShort();
			}
			this.kamas = reader.ReadVarUhInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.objects.Length));
			uint[] numArray = this.objects;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteVarInt((int)this.kamas);
		}
	}
}