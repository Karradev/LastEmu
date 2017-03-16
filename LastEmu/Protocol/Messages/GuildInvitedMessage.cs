using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildInvitedMessage : NetworkMessage
	{
		public const uint Id = 5552;

		public double recruterId;

		public string recruterName;

		public BasicGuildInformations guildInfo;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5552;
			}
		}

		public GuildInvitedMessage()
		{
		}

		public GuildInvitedMessage(double recruterId, string recruterName, BasicGuildInformations guildInfo)
		{
			this.recruterId = recruterId;
			this.recruterName = recruterName;
			this.guildInfo = guildInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.recruterId = reader.ReadVarUhLong();
			this.recruterName = reader.ReadUTF();
			this.guildInfo = new BasicGuildInformations();
			this.guildInfo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.recruterId);
			writer.WriteUTF(this.recruterName);
			this.guildInfo.Serialize(writer);
		}
	}
}