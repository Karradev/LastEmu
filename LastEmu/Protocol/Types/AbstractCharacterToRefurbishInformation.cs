using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AbstractCharacterToRefurbishInformation : AbstractCharacterInformation
	{
		public const short Id = 475;

		public int[] colors;

		public uint cosmeticId;

		public override short TypeId
		{
			get
			{
				return 475;
			}
		}

		public AbstractCharacterToRefurbishInformation()
		{
		}

		public AbstractCharacterToRefurbishInformation(double id, int[] colors, uint cosmeticId) : base(id)
		{
			this.colors = colors;
			this.cosmeticId = cosmeticId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.colors = new int[num];
			for (int i = 0; i < num; i++)
			{
				this.colors[i] = reader.ReadInt();
			}
			this.cosmeticId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.colors.Length));
			int[] numArray = this.colors;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteInt(numArray[i]);
			}
			writer.WriteVarInt((int)this.cosmeticId);
		}
	}
}