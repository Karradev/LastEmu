using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GuildBulletinSetRequestMessage : SocialNoticeSetRequestMessage
	{
		public const uint Id = 6694;

		public string content;

		public bool notifyMembers;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6694;
			}
		}

		public GuildBulletinSetRequestMessage()
		{
		}

		public GuildBulletinSetRequestMessage(string content, bool notifyMembers)
		{
			this.content = content;
			this.notifyMembers = notifyMembers;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.content = reader.ReadUTF();
			this.notifyMembers = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.content);
			writer.WriteBoolean(this.notifyMembers);
		}
	}
}