using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameActionNoopMessage : NetworkMessage
	{
		public const uint Id = 1002;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1002;
			}
		}

		public GameActionNoopMessage()
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