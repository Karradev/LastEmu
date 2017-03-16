using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class GameRolePlayGroupMonsterWaveInformations : GameRolePlayGroupMonsterInformations
	{
		public const short Id = 464;

		public sbyte nbWaves;

		public GroupMonsterStaticInformations[] alternatives;

		public override short TypeId
		{
			get
			{
				return 464;
			}
		}

		public GameRolePlayGroupMonsterWaveInformations()
		{
		}

		public GameRolePlayGroupMonsterWaveInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, bool keyRingBonus, bool hasHardcoreDrop, bool hasAVARewardToken, GroupMonsterStaticInformations staticInfos, double creationTime, int ageBonusRate, sbyte lootShare, sbyte alignmentSide, sbyte nbWaves, GroupMonsterStaticInformations[] alternatives) : base(contextualId, look, disposition, keyRingBonus, hasHardcoreDrop, hasAVARewardToken, staticInfos, creationTime, ageBonusRate, lootShare, alignmentSide)
		{
			this.nbWaves = nbWaves;
			this.alternatives = alternatives;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.nbWaves = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.alternatives = new GroupMonsterStaticInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.alternatives[i] = ProtocolTypeManager.GetInstance<GroupMonsterStaticInformations>(reader.ReadUShort());
				this.alternatives[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.nbWaves);
			writer.WriteShort((short)((int)this.alternatives.Length));
			GroupMonsterStaticInformations[] groupMonsterStaticInformationsArray = this.alternatives;
			for (int i = 0; i < (int)groupMonsterStaticInformationsArray.Length; i++)
			{
				GroupMonsterStaticInformations groupMonsterStaticInformation = groupMonsterStaticInformationsArray[i];
				writer.WriteShort(groupMonsterStaticInformation.TypeId);
				groupMonsterStaticInformation.Serialize(writer);
			}
		}
	}
}