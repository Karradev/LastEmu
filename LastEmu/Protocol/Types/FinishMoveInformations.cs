using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FinishMoveInformations
	{
		public const short Id = 506;

		public int finishMoveId;

		public bool finishMoveState;

		public virtual short TypeId
		{
			get
			{
				return 506;
			}
		}

		public FinishMoveInformations()
		{
		}

		public FinishMoveInformations(int finishMoveId, bool finishMoveState)
		{
			this.finishMoveId = finishMoveId;
			this.finishMoveState = finishMoveState;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.finishMoveId = reader.ReadInt();
			this.finishMoveState = reader.ReadBoolean();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.finishMoveId);
			writer.WriteBoolean(this.finishMoveState);
		}
	}
}