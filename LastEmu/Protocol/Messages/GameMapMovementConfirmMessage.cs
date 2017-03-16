using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameMapMovementConfirmMessage : NetworkMessage
	{
		public const uint Id = 952;

		public override uint ProtocolId
		{
			get
			{
				return (uint)952;
			}
		}

		public GameMapMovementConfirmMessage()
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