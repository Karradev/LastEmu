using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class JobExperience
	{
		public const short Id = 98;

		public sbyte jobId;

		public byte jobLevel;

		public double jobXP;

		public double jobXpLevelFloor;

		public double jobXpNextLevelFloor;

		public virtual short TypeId
		{
			get
			{
				return 98;
			}
		}

		public JobExperience()
		{
		}

		public JobExperience(sbyte jobId, byte jobLevel, double jobXP, double jobXpLevelFloor, double jobXpNextLevelFloor)
		{
			this.jobId = jobId;
			this.jobLevel = jobLevel;
			this.jobXP = jobXP;
			this.jobXpLevelFloor = jobXpLevelFloor;
			this.jobXpNextLevelFloor = jobXpNextLevelFloor;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.jobId = reader.ReadSByte();
			this.jobLevel = reader.ReadByte();
			this.jobXP = reader.ReadVarUhLong();
			this.jobXpLevelFloor = reader.ReadVarUhLong();
			this.jobXpNextLevelFloor = reader.ReadVarUhLong();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.jobId);
			writer.WriteByte(this.jobLevel);
			writer.WriteVarLong(this.jobXP);
			writer.WriteVarLong(this.jobXpLevelFloor);
			writer.WriteVarLong(this.jobXpNextLevelFloor);
		}
	}
}