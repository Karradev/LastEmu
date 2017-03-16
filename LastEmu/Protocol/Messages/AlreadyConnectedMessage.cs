using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AlreadyConnectedMessage : NetworkMessage
	{
		public const uint Id = 109;

		public override uint ProtocolId
		{
			get
			{
				return (uint)109;
			}
		}

		public AlreadyConnectedMessage()
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