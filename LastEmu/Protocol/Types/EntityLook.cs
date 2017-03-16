using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class EntityLook
	{
		public const short Id = 55;

		public uint bonesId;

		public uint[] skins;

		public int[] indexedColors;

		public int[] scales;

		public SubEntity[] subentities;

		public virtual short TypeId
		{
			get
			{
				return 55;
			}
		}

		public EntityLook()
		{
		}

		public EntityLook(uint bonesId, uint[] skins, int[] indexedColors, int[] scales, SubEntity[] subentities)
		{
			this.bonesId = bonesId;
			this.skins = skins;
			this.indexedColors = indexedColors;
			this.scales = scales;
			this.subentities = subentities;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.bonesId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.skins = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.skins[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.indexedColors = new int[num];
			for (int j = 0; j < num; j++)
			{
				this.indexedColors[j] = reader.ReadInt();
			}
			num = reader.ReadUShort();
			this.scales = new int[num];
			for (int k = 0; k < num; k++)
			{
				this.scales[k] = reader.ReadVarShort();
			}
			num = reader.ReadUShort();
			this.subentities = new SubEntity[num];
			for (int l = 0; l < num; l++)
			{
				this.subentities[l] = new SubEntity();
				this.subentities[l].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.bonesId);
			writer.WriteShort((short)((int)this.skins.Length));
			uint[] numArray = this.skins;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.indexedColors.Length));
			int[] numArray1 = this.indexedColors;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteInt(numArray1[j]);
			}
			writer.WriteShort((short)((int)this.scales.Length));
			int[] numArray2 = this.scales;
			for (int k = 0; k < (int)numArray2.Length; k++)
			{
				writer.WriteVarShort(numArray2[k]);
			}
			writer.WriteShort((short)((int)this.subentities.Length));
			SubEntity[] subEntityArray = this.subentities;
			for (int l = 0; l < (int)subEntityArray.Length; l++)
			{
				subEntityArray[l].Serialize(writer);
			}
		}
	}
}