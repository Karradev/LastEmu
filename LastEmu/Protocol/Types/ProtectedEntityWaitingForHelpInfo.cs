using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ProtectedEntityWaitingForHelpInfo
	{
		public const short Id = 186;

		public int timeLeftBeforeFight;

		public int waitTimeForPlacement;

		public sbyte nbPositionForDefensors;

		public virtual short TypeId
		{
			get
			{
				return 186;
			}
		}

		public ProtectedEntityWaitingForHelpInfo()
		{
		}

		public ProtectedEntityWaitingForHelpInfo(int timeLeftBeforeFight, int waitTimeForPlacement, sbyte nbPositionForDefensors)
		{
			this.timeLeftBeforeFight = timeLeftBeforeFight;
			this.waitTimeForPlacement = waitTimeForPlacement;
			this.nbPositionForDefensors = nbPositionForDefensors;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.timeLeftBeforeFight = reader.ReadInt();
			this.waitTimeForPlacement = reader.ReadInt();
			this.nbPositionForDefensors = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.timeLeftBeforeFight);
			writer.WriteInt(this.waitTimeForPlacement);
			writer.WriteSByte(this.nbPositionForDefensors);
		}
	}
}