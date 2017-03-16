using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightPlacementSwapPositionsCancelMessage : NetworkMessage
	{
		public const uint Id = 6543;

		public int requestId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6543;
			}
		}

		public GameFightPlacementSwapPositionsCancelMessage()
		{
		}

		public GameFightPlacementSwapPositionsCancelMessage(int requestId)
		{
			this.requestId = requestId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.requestId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.requestId);
		}
	}
}