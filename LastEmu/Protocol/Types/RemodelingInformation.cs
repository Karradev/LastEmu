using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class RemodelingInformation
	{
		public const short Id = 480;

		public string name;

		public sbyte breed;

		public bool sex;

		public uint cosmeticId;

		public int[] colors;

		public virtual short TypeId
		{
			get
			{
				return 480;
			}
		}

		public RemodelingInformation()
		{
		}

		public RemodelingInformation(string name, sbyte breed, bool sex, uint cosmeticId, int[] colors)
		{
			this.name = name;
			this.breed = breed;
			this.sex = sex;
			this.cosmeticId = cosmeticId;
			this.colors = colors;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.name = reader.ReadUTF();
			this.breed = reader.ReadSByte();
			this.sex = reader.ReadBoolean();
			this.cosmeticId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.colors = new int[num];
			for (int i = 0; i < num; i++)
			{
				this.colors[i] = reader.ReadInt();
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.name);
			writer.WriteSByte(this.breed);
			writer.WriteBoolean(this.sex);
			writer.WriteVarShort((int)this.cosmeticId);
			writer.WriteShort((short)((int)this.colors.Length));
			int[] numArray = this.colors;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteInt(numArray[i]);
			}
		}
	}
}