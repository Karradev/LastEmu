using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightPlacementSwapPositionsAcceptMessage : NetworkMessage
	{
		public const uint Id = 6547;

		public int requestId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6547;
			}
		}

		public GameFightPlacementSwapPositionsAcceptMessage()
		{
		}

		public GameFightPlacementSwapPositionsAcceptMessage(int requestId)
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