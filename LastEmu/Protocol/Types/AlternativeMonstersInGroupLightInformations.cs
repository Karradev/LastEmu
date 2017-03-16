using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AlternativeMonstersInGroupLightInformations
	{
		public const short Id = 394;

		public int playerCount;

		public MonsterInGroupLightInformations[] monsters;

		public virtual short TypeId
		{
			get
			{
				return 394;
			}
		}

		public AlternativeMonstersInGroupLightInformations()
		{
		}

		public AlternativeMonstersInGroupLightInformations(int playerCount, MonsterInGroupLightInformations[] monsters)
		{
			this.playerCount = playerCount;
			this.monsters = monsters;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.playerCount = reader.ReadInt();
			ushort num = reader.ReadUShort();
			this.monsters = new MonsterInGroupLightInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.monsters[i] = new MonsterInGroupLightInformations();
				this.monsters[i].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.playerCount);
			writer.WriteShort((short)((int)this.monsters.Length));
			MonsterInGroupLightInformations[] monsterInGroupLightInformationsArray = this.monsters;
			for (int i = 0; i < (int)monsterInGroupLightInformationsArray.Length; i++)
			{
				monsterInGroupLightInformationsArray[i].Serialize(writer);
			}
		}
	}
}