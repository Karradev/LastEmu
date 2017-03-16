using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterSpellModification
	{
		public const short Id = 215;

		public sbyte modificationType;

		public uint spellId;

		public CharacterBaseCharacteristic @value;

		public virtual short TypeId
		{
			get
			{
				return 215;
			}
		}

		public CharacterSpellModification()
		{
		}

		public CharacterSpellModification(sbyte modificationType, uint spellId, CharacterBaseCharacteristic value)
		{
			this.modificationType = modificationType;
			this.spellId = spellId;
			this.@value = value;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.modificationType = reader.ReadSByte();
			this.spellId = reader.ReadVarUhShort();
			this.@value = new CharacterBaseCharacteristic();
			this.@value.Deserialize(reader);
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.modificationType);
			writer.WriteVarShort((int)this.spellId);
			this.@value.Serialize(writer);
		}
	}
}