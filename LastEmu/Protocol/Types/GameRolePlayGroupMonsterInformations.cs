using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class GameRolePlayGroupMonsterInformations : GameRolePlayActorInformations
	{
		public const short Id = 160;

		public bool keyRingBonus;

		public bool hasHardcoreDrop;

		public bool hasAVARewardToken;

		public GroupMonsterStaticInformations staticInfos;

		public double creationTime;

		public int ageBonusRate;

		public sbyte lootShare;

		public sbyte alignmentSide;

		public override short TypeId
		{
			get
			{
				return 160;
			}
		}

		public GameRolePlayGroupMonsterInformations()
		{
		}

		public GameRolePlayGroupMonsterInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, bool keyRingBonus, bool hasHardcoreDrop, bool hasAVARewardToken, GroupMonsterStaticInformations staticInfos, double creationTime, int ageBonusRate, sbyte lootShare, sbyte alignmentSide) : base(contextualId, look, disposition)
		{
			this.keyRingBonus = keyRingBonus;
			this.hasHardcoreDrop = hasHardcoreDrop;
			this.hasAVARewardToken = hasAVARewardToken;
			this.staticInfos = staticInfos;
			this.creationTime = creationTime;
			this.ageBonusRate = ageBonusRate;
			this.lootShare = lootShare;
			this.alignmentSide = alignmentSide;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			byte num = reader.ReadByte();
			this.keyRingBonus = BooleanByteWrapper.GetFlag(num, 0);
			this.hasHardcoreDrop = BooleanByteWrapper.GetFlag(num, 1);
			this.hasAVARewardToken = BooleanByteWrapper.GetFlag(num, 2);
			this.staticInfos = ProtocolTypeManager.GetInstance<GroupMonsterStaticInformations>(reader.ReadUShort());
			this.staticInfos.Deserialize(reader);
			this.creationTime = reader.ReadDouble();
			this.ageBonusRate = reader.ReadInt();
			this.lootShare = reader.ReadSByte();
			this.alignmentSide = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.keyRingBonus);
			num = BooleanByteWrapper.SetFlag(num, 1, this.hasHardcoreDrop);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 2, this.hasAVARewardToken));
			writer.WriteShort(this.staticInfos.TypeId);
			this.staticInfos.Serialize(writer);
			writer.WriteDouble(this.creationTime);
			writer.WriteInt(this.ageBonusRate);
			writer.WriteSByte(this.lootShare);
			writer.WriteSByte(this.alignmentSide);
		}
	}
}