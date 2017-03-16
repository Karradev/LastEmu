using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTeamMemberCompanionInformations : FightTeamMemberInformations
	{
		public const short Id = 451;

		public sbyte companionId;

		public byte level;

		public double masterId;

		public override short TypeId
		{
			get
			{
				return 451;
			}
		}

		public FightTeamMemberCompanionInformations()
		{
		}

		public FightTeamMemberCompanionInformations(double id, sbyte companionId, byte level, double masterId) : base(id)
		{
			this.companionId = companionId;
			this.level = level;
			this.masterId = masterId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.companionId = reader.ReadSByte();
			this.level = reader.ReadByte();
			this.masterId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.companionId);
			writer.WriteByte(this.level);
			writer.WriteDouble(this.masterId);
		}
	}
}