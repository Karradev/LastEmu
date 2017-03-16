using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameContextCreateRequestMessage : NetworkMessage
	{
		public const uint Id = 250;

		public override uint ProtocolId
		{
			get
			{
				return (uint)250;
			}
		}

		public GameContextCreateRequestMessage()
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