using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AuthenticationTicketMessage : NetworkMessage
	{
		public const uint Id = 110;

		public string lang;

		public string ticket;

		public override uint ProtocolId
		{
			get
			{
				return (uint)110;
			}
		}

		public AuthenticationTicketMessage()
		{
		}

		public AuthenticationTicketMessage(string lang, string ticket)
		{
			this.lang = lang;
			this.ticket = ticket;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.lang = reader.ReadUTF();
			this.ticket = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.lang);
			writer.WriteUTF(this.ticket);
		}
	}
}