using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterBaseCharacteristic
	{
		public const short Id = 4;

		public int @base;

		public int additionnal;

		public int objectsAndMountBonus;

		public int alignGiftBonus;

		public int contextModif;

		public virtual short TypeId
		{
			get
			{
				return 4;
			}
		}

		public CharacterBaseCharacteristic()
		{
		}

		public CharacterBaseCharacteristic(int @base, int additionnal, int objectsAndMountBonus, int alignGiftBonus, int contextModif)
		{
			this.@base = @base;
			this.additionnal = additionnal;
			this.objectsAndMountBonus = objectsAndMountBonus;
			this.alignGiftBonus = alignGiftBonus;
			this.contextModif = contextModif;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.@base = reader.ReadVarShort();
			this.additionnal = reader.ReadVarShort();
			this.objectsAndMountBonus = reader.ReadVarShort();
			this.alignGiftBonus = reader.ReadVarShort();
			this.contextModif = reader.ReadVarShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort(this.@base);
			writer.WriteVarShort(this.additionnal);
			writer.WriteVarShort(this.objectsAndMountBonus);
			writer.WriteVarShort(this.alignGiftBonus);
			writer.WriteVarShort(this.contextModif);
		}
	}
}