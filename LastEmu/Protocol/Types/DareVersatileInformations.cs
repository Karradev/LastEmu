using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class DareVersatileInformations
	{
		public const short Id = 504;

		public double dareId;

		public int countEntrants;

		public int countWinners;

		public virtual short TypeId
		{
			get
			{
				return 504;
			}
		}

		public DareVersatileInformations()
		{
		}

		public DareVersatileInformations(double dareId, int countEntrants, int countWinners)
		{
			this.dareId = dareId;
			this.countEntrants = countEntrants;
			this.countWinners = countWinners;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.dareId = reader.ReadDouble();
			this.countEntrants = reader.ReadInt();
			this.countWinners = reader.ReadInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.dareId);
			writer.WriteInt(this.countEntrants);
			writer.WriteInt(this.countWinners);
		}
	}
}