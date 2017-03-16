using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GroupMonsterStaticInformationsWithAlternatives : GroupMonsterStaticInformations
	{
		public const short Id = 396;

		public AlternativeMonstersInGroupLightInformations[] alternatives;

		public override short TypeId
		{
			get
			{
				return 396;
			}
		}

		public GroupMonsterStaticInformationsWithAlternatives()
		{
		}

		public GroupMonsterStaticInformationsWithAlternatives(MonsterInGroupLightInformations mainCreatureLightInfos, MonsterInGroupInformations[] underlings, AlternativeMonstersInGroupLightInformations[] alternatives) : base(mainCreatureLightInfos, underlings)
		{
			this.alternatives = alternatives;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.alternatives = new AlternativeMonstersInGroupLightInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.alternatives[i] = new AlternativeMonstersInGroupLightInformations();
				this.alternatives[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.alternatives.Length));
			AlternativeMonstersInGroupLightInformations[] alternativeMonstersInGroupLightInformationsArray = this.alternatives;
			for (int i = 0; i < (int)alternativeMonstersInGroupLightInformationsArray.Length; i++)
			{
				alternativeMonstersInGroupLightInformationsArray[i].Serialize(writer);
			}
		}
	}
}