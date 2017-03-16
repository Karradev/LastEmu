using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightPlacementSwapPositionsCancelledMessage : NetworkMessage
	{
		public const uint Id = 6546;

		public int requestId;

		public double cancellerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6546;
			}
		}

		public GameFightPlacementSwapPositionsCancelledMessage()
		{
		}

		public GameFightPlacementSwapPositionsCancelledMessage(int requestId, double cancellerId)
		{
			this.requestId = requestId;
			this.cancellerId = cancellerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.requestId = reader.ReadInt();
			this.cancellerId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.requestId);
			writer.WriteDouble(this.cancellerId);
		}
	}
}