using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameContextQuitMessage : NetworkMessage
	{
		public const uint Id = 255;

		public override uint ProtocolId
		{
			get
			{
				return (uint)255;
			}
		}

		public GameContextQuitMessage()
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