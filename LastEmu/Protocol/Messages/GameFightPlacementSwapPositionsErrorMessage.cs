using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightPlacementSwapPositionsErrorMessage : NetworkMessage
	{
		public const uint Id = 6548;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6548;
			}
		}

		public GameFightPlacementSwapPositionsErrorMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}