using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AbstractFightTeamInformations
	{
		public const short Id = 116;

		public sbyte teamId;

		public double leaderId;

		public sbyte teamSide;

		public sbyte teamTypeId;

		public sbyte nbWaves;

		public virtual short TypeId
		{
			get
			{
				return 116;
			}
		}

		public AbstractFightTeamInformations()
		{
		}

		public AbstractFightTeamInformations(sbyte teamId, double leaderId, sbyte teamSide, sbyte teamTypeId, sbyte nbWaves)
		{
			this.teamId = teamId;
			this.leaderId = leaderId;
			this.teamSide = teamSide;
			this.teamTypeId = teamTypeId;
			this.nbWaves = nbWaves;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.teamId = reader.ReadSByte();
			this.leaderId = reader.ReadDouble();
			this.teamSide = reader.ReadSByte();
			this.teamTypeId = reader.ReadSByte();
			this.nbWaves = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.teamId);
			writer.WriteDouble(this.leaderId);
			writer.WriteSByte(this.teamSide);
			writer.WriteSByte(this.teamTypeId);
			writer.WriteSByte(this.nbWaves);
		}
	}
}