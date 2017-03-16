using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class FightTeamLightInformations : AbstractFightTeamInformations
	{
		public const short Id = 115;

		public bool hasFriend;

		public bool hasGuildMember;

		public bool hasAllianceMember;

		public bool hasGroupMember;

		public bool hasMyTaxCollector;

		public sbyte teamMembersCount;

		public uint meanLevel;

		public override short TypeId
		{
			get
			{
				return 115;
			}
		}

		public FightTeamLightInformations()
		{
		}

		public FightTeamLightInformations(sbyte teamId, double leaderId, sbyte teamSide, sbyte teamTypeId, sbyte nbWaves, bool hasFriend, bool hasGuildMember, bool hasAllianceMember, bool hasGroupMember, bool hasMyTaxCollector, sbyte teamMembersCount, uint meanLevel) : base(teamId, leaderId, teamSide, teamTypeId, nbWaves)
		{
			this.hasFriend = hasFriend;
			this.hasGuildMember = hasGuildMember;
			this.hasAllianceMember = hasAllianceMember;
			this.hasGroupMember = hasGroupMember;
			this.hasMyTaxCollector = hasMyTaxCollector;
			this.teamMembersCount = teamMembersCount;
			this.meanLevel = meanLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			byte num = reader.ReadByte();
			this.hasFriend = BooleanByteWrapper.GetFlag(num, 0);
			this.hasGuildMember = BooleanByteWrapper.GetFlag(num, 1);
			this.hasAllianceMember = BooleanByteWrapper.GetFlag(num, 2);
			this.hasGroupMember = BooleanByteWrapper.GetFlag(num, 3);
			this.hasMyTaxCollector = BooleanByteWrapper.GetFlag(num, 4);
			this.teamMembersCount = reader.ReadSByte();
			this.meanLevel = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.hasFriend);
			num = BooleanByteWrapper.SetFlag(num, 1, this.hasGuildMember);
			num = BooleanByteWrapper.SetFlag(num, 2, this.hasAllianceMember);
			num = BooleanByteWrapper.SetFlag(num, 3, this.hasGroupMember);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 4, this.hasMyTaxCollector));
			writer.WriteSByte(this.teamMembersCount);
			writer.WriteVarInt((int)this.meanLevel);
		}
	}
}