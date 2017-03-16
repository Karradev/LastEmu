using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTeamMemberMonsterInformations : FightTeamMemberInformations
	{
		public const short Id = 6;

		public int monsterId;

		public sbyte grade;

		public override short TypeId
		{
			get
			{
				return 6;
			}
		}

		public FightTeamMemberMonsterInformations()
		{
		}

		public FightTeamMemberMonsterInformations(double id, int monsterId, sbyte grade) : base(id)
		{
			this.monsterId = monsterId;
			this.grade = grade;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.monsterId = reader.ReadInt();
			this.grade = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.monsterId);
			writer.WriteSByte(this.grade);
		}
	}
}