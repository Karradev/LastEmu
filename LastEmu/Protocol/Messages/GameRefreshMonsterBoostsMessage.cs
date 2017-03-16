using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameRefreshMonsterBoostsMessage : NetworkMessage
	{
		public const uint Id = 6618;

		public MonsterBoosts[] monsterBoosts;

		public MonsterBoosts[] familyBoosts;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6618;
			}
		}

		public GameRefreshMonsterBoostsMessage()
		{
		}

		public GameRefreshMonsterBoostsMessage(MonsterBoosts[] monsterBoosts, MonsterBoosts[] familyBoosts)
		{
			this.monsterBoosts = monsterBoosts;
			this.familyBoosts = familyBoosts;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.monsterBoosts = new MonsterBoosts[num];
			for (int i = 0; i < num; i++)
			{
				this.monsterBoosts[i] = new MonsterBoosts();
				this.monsterBoosts[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.familyBoosts = new MonsterBoosts[num];
			for (int j = 0; j < num; j++)
			{
				this.familyBoosts[j] = new MonsterBoosts();
				this.familyBoosts[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.monsterBoosts.Length));
			MonsterBoosts[] monsterBoostsArray = this.monsterBoosts;
			for (int i = 0; i < (int)monsterBoostsArray.Length; i++)
			{
				monsterBoostsArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.familyBoosts.Length));
			MonsterBoosts[] monsterBoostsArray1 = this.familyBoosts;
			for (int j = 0; j < (int)monsterBoostsArray1.Length; j++)
			{
				monsterBoostsArray1[j].Serialize(writer);
			}
		}
	}
}