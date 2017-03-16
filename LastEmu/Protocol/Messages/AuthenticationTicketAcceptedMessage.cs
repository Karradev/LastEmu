using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AuthenticationTicketAcceptedMessage : NetworkMessage
	{
		public const uint Id = 111;

		public override uint ProtocolId
		{
			get
			{
				return (uint)111;
			}
		}

		public AuthenticationTicketAcceptedMessage()
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