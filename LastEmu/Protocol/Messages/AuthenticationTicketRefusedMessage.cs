using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AuthenticationTicketRefusedMessage : NetworkMessage
	{
		public const uint Id = 112;

		public override uint ProtocolId
		{
			get
			{
				return (uint)112;
			}
		}

		public AuthenticationTicketRefusedMessage()
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