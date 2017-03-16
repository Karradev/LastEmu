using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterRemodelingInformation : AbstractCharacterInformation
	{
		public const short Id = 479;

		public string name;

		public sbyte breed;

		public bool sex;

		public uint cosmeticId;

		public int[] colors;

		public override short TypeId
		{
			get
			{
				return 479;
			}
		}

		public CharacterRemodelingInformation()
		{
		}

		public CharacterRemodelingInformation(double id, string name, sbyte breed, bool sex, uint cosmeticId, int[] colors) : base(id)
		{
			this.name = name;
			this.breed = breed;
			this.sex = sex;
			this.cosmeticId = cosmeticId;
			this.colors = colors;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
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

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
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