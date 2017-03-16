using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterCreationRequestMessage : NetworkMessage
	{
		public const uint Id = 160;

		public string name;

		public sbyte breed;

		public bool sex;

		public int[] colors;

		public uint cosmeticId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)160;
			}
		}

		public CharacterCreationRequestMessage()
		{
		}

		public CharacterCreationRequestMessage(string name, sbyte breed, bool sex, int[] colors, uint cosmeticId)
		{
			this.name = name;
			this.breed = breed;
			this.sex = sex;
			this.colors = colors;
			this.cosmeticId = cosmeticId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.name = reader.ReadUTF();
			this.breed = reader.ReadSByte();
			this.sex = reader.ReadBoolean();
			ushort num = reader.ReadUShort();
			this.colors = new int[num];
			for (int i = 0; i < num; i++)
			{
				this.colors[i] = reader.ReadInt();
			}
			this.cosmeticId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.name);
			writer.WriteSByte(this.breed);
			writer.WriteBoolean(this.sex);
			writer.WriteShort((short)((int)this.colors.Length));
			int[] numArray = this.colors;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteInt(numArray[i]);
			}
			writer.WriteVarShort((int)this.cosmeticId);
		}
	}
}