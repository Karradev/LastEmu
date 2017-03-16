using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PartyInvitationRequestMessage : NetworkMessage
	{
		public const uint Id = 5585;

		public string name;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5585;
			}
		}

		public PartyInvitationRequestMessage()
		{
		}

		public PartyInvitationRequestMessage(string name)
		{
			this.name = name;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.name = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.name);
		}
	}
}