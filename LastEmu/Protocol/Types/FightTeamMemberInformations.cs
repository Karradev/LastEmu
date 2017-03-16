using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTeamMemberInformations
	{
		public const short Id = 44;

		public double id;

		public virtual short TypeId
		{
			get
			{
				return 44;
			}
		}

		public FightTeamMemberInformations()
		{
		}

		public FightTeamMemberInformations(double id)
		{
			this.id = id;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadDouble();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.id);
		}
	}
}