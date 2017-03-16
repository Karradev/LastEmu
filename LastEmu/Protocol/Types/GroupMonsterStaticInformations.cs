using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GroupMonsterStaticInformations
	{
		public const short Id = 140;

		public MonsterInGroupLightInformations mainCreatureLightInfos;

		public MonsterInGroupInformations[] underlings;

		public virtual short TypeId
		{
			get
			{
				return 140;
			}
		}

		public GroupMonsterStaticInformations()
		{
		}

		public GroupMonsterStaticInformations(MonsterInGroupLightInformations mainCreatureLightInfos, MonsterInGroupInformations[] underlings)
		{
			this.mainCreatureLightInfos = mainCreatureLightInfos;
			this.underlings = underlings;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.mainCreatureLightInfos = new MonsterInGroupLightInformations();
			this.mainCreatureLightInfos.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.underlings = new MonsterInGroupInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.underlings[i] = new MonsterInGroupInformations();
				this.underlings[i].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			this.mainCreatureLightInfos.Serialize(writer);
			writer.WriteShort((short)((int)this.underlings.Length));
			MonsterInGroupInformations[] monsterInGroupInformationsArray = this.underlings;
			for (int i = 0; i < (int)monsterInGroupInformationsArray.Length; i++)
			{
				monsterInGroupInformationsArray[i].Serialize(writer);
			}
		}
	}
}