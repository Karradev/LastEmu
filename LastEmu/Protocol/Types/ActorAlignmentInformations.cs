using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ActorAlignmentInformations
	{
		public const short Id = 201;

		public sbyte alignmentSide;

		public sbyte alignmentValue;

		public sbyte alignmentGrade;

		public double characterPower;

		public virtual short TypeId
		{
			get
			{
				return 201;
			}
		}

		public ActorAlignmentInformations()
		{
		}

		public ActorAlignmentInformations(sbyte alignmentSide, sbyte alignmentValue, sbyte alignmentGrade, double characterPower)
		{
			this.alignmentSide = alignmentSide;
			this.alignmentValue = alignmentValue;
			this.alignmentGrade = alignmentGrade;
			this.characterPower = characterPower;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.alignmentSide = reader.ReadSByte();
			this.alignmentValue = reader.ReadSByte();
			this.alignmentGrade = reader.ReadSByte();
			this.characterPower = reader.ReadDouble();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.alignmentSide);
			writer.WriteSByte(this.alignmentValue);
			writer.WriteSByte(this.alignmentGrade);
			writer.WriteDouble(this.characterPower);
		}
	}
}