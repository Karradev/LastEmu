using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildInvitationByNameMessage : NetworkMessage
	{
		public const uint Id = 6115;

		public string name;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6115;
			}
		}

		public GuildInvitationByNameMessage()
		{
		}

		public GuildInvitationByNameMessage(string name)
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