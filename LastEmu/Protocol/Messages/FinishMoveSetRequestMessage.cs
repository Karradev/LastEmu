using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FinishMoveSetRequestMessage : NetworkMessage
	{
		public const uint Id = 6703;

		public int finishMoveId;

		public bool finishMoveState;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6703;
			}
		}

		public FinishMoveSetRequestMessage()
		{
		}

		public FinishMoveSetRequestMessage(int finishMoveId, bool finishMoveState)
		{
			this.finishMoveId = finishMoveId;
			this.finishMoveState = finishMoveState;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.finishMoveId = reader.ReadInt();
			this.finishMoveState = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.finishMoveId);
			writer.WriteBoolean(this.finishMoveState);
		}
	}
}