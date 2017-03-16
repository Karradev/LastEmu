using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameContextDestroyMessage : NetworkMessage
	{
		public const uint Id = 201;

		public override uint ProtocolId
		{
			get
			{
				return (uint)201;
			}
		}

		public GameContextDestroyMessage()
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