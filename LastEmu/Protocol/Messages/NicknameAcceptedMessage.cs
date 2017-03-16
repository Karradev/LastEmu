using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NicknameAcceptedMessage : NetworkMessage
	{
		public const uint Id = 5641;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5641;
			}
		}

		public NicknameAcceptedMessage()
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