using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightTurnStartPlayingMessage : NetworkMessage
	{
		public const uint Id = 6465;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6465;
			}
		}

		public GameFightTurnStartPlayingMessage()
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