using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ActorExtendedAlignmentInformations : ActorAlignmentInformations
	{
		public const short Id = 202;

		public uint honor;

		public uint honorGradeFloor;

		public uint honorNextGradeFloor;

		public sbyte aggressable;

		public override short TypeId
		{
			get
			{
				return 202;
			}
		}

		public ActorExtendedAlignmentInformations()
		{
		}

		public ActorExtendedAlignmentInformations(sbyte alignmentSide, sbyte alignmentValue, sbyte alignmentGrade, double characterPower, uint honor, uint honorGradeFloor, uint honorNextGradeFloor, sbyte aggressable) : base(alignmentSide, alignmentValue, alignmentGrade, characterPower)
		{
			this.honor = honor;
			this.honorGradeFloor = honorGradeFloor;
			this.honorNextGradeFloor = honorNextGradeFloor;
			this.aggressable = aggressable;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.honor = reader.ReadVarUhShort();
			this.honorGradeFloor = reader.ReadVarUhShort();
			this.honorNextGradeFloor = reader.ReadVarUhShort();
			this.aggressable = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.honor);
			writer.WriteVarShort((int)this.honorGradeFloor);
			writer.WriteVarShort((int)this.honorNextGradeFloor);
			writer.WriteSByte(this.aggressable);
		}
	}
}