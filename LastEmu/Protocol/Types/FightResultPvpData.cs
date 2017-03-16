using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightResultPvpData : FightResultAdditionalData
	{
		public const short Id = 190;

		public byte grade;

		public uint minHonorForGrade;

		public uint maxHonorForGrade;

		public uint honor;

		public int honorDelta;

		public override short TypeId
		{
			get
			{
				return 190;
			}
		}

		public FightResultPvpData()
		{
		}

		public FightResultPvpData(byte grade, uint minHonorForGrade, uint maxHonorForGrade, uint honor, int honorDelta)
		{
			this.grade = grade;
			this.minHonorForGrade = minHonorForGrade;
			this.maxHonorForGrade = maxHonorForGrade;
			this.honor = honor;
			this.honorDelta = honorDelta;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.grade = reader.ReadByte();
			this.minHonorForGrade = reader.ReadVarUhShort();
			this.maxHonorForGrade = reader.ReadVarUhShort();
			this.honor = reader.ReadVarUhShort();
			this.honorDelta = reader.ReadVarShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(this.grade);
			writer.WriteVarShort((int)this.minHonorForGrade);
			writer.WriteVarShort((int)this.maxHonorForGrade);
			writer.WriteVarShort((int)this.honor);
			writer.WriteVarShort(this.honorDelta);
		}
	}
}