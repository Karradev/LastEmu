using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NicknameRegistrationMessage : NetworkMessage
	{
		public const uint Id = 5640;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5640;
			}
		}

		public NicknameRegistrationMessage()
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