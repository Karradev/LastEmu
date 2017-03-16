using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class SpellListMessage : NetworkMessage
	{
		public const uint Id = 1200;

		public bool spellPrevisualization;

		public SpellItem[] spells;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1200;
			}
		}

		public SpellListMessage()
		{
		}

		public SpellListMessage(bool spellPrevisualization, SpellItem[] spells)
		{
			this.spellPrevisualization = spellPrevisualization;
			this.spells = spells;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.spellPrevisualization = reader.ReadBoolean();
			ushort num = reader.ReadUShort();
			this.spells = new SpellItem[num];
			for (int i = 0; i < num; i++)
			{
				this.spells[i] = new SpellItem();
				this.spells[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.spellPrevisualization);
			writer.WriteShort((short)((int)this.spells.Length));
			SpellItem[] spellItemArray = this.spells;
			for (int i = 0; i < (int)spellItemArray.Length; i++)
			{
				spellItemArray[i].Serialize(writer);
			}
		}
	}
}