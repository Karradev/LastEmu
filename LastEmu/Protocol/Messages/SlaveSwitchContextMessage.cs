using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class SlaveSwitchContextMessage : NetworkMessage
	{
		public const uint Id = 6214;

		public double masterId;

		public double slaveId;

		public SpellItem[] slaveSpells;

		public CharacterCharacteristicsInformations slaveStats;

		public Shortcut[] shortcuts;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6214;
			}
		}

		public SlaveSwitchContextMessage()
		{
		}

		public SlaveSwitchContextMessage(double masterId, double slaveId, SpellItem[] slaveSpells, CharacterCharacteristicsInformations slaveStats, Shortcut[] shortcuts)
		{
			this.masterId = masterId;
			this.slaveId = slaveId;
			this.slaveSpells = slaveSpells;
			this.slaveStats = slaveStats;
			this.shortcuts = shortcuts;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.masterId = reader.ReadDouble();
			this.slaveId = reader.ReadDouble();
			ushort num = reader.ReadUShort();
			this.slaveSpells = new SpellItem[num];
			for (int i = 0; i < num; i++)
			{
				this.slaveSpells[i] = new SpellItem();
				this.slaveSpells[i].Deserialize(reader);
			}
			this.slaveStats = new CharacterCharacteristicsInformations();
			this.slaveStats.Deserialize(reader);
			num = reader.ReadUShort();
			this.shortcuts = new Shortcut[num];
			for (int j = 0; j < num; j++)
			{
				this.shortcuts[j] = ProtocolTypeManager.GetInstance<Shortcut>(reader.ReadUShort());
				this.shortcuts[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.masterId);
			writer.WriteDouble(this.slaveId);
			writer.WriteShort((short)((int)this.slaveSpells.Length));
			SpellItem[] spellItemArray = this.slaveSpells;
			for (int i = 0; i < (int)spellItemArray.Length; i++)
			{
				spellItemArray[i].Serialize(writer);
			}
			this.slaveStats.Serialize(writer);
			writer.WriteShort((short)((int)this.shortcuts.Length));
			Shortcut[] shortcutArray = this.shortcuts;
			for (int j = 0; j < (int)shortcutArray.Length; j++)
			{
				Shortcut shortcut = shortcutArray[j];
				writer.WriteShort(shortcut.TypeId);
				shortcut.Serialize(writer);
			}
		}
	}
}