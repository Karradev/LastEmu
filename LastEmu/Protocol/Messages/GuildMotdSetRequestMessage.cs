using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GuildMotdSetRequestMessage : SocialNoticeSetRequestMessage
	{
		public const uint Id = 6588;

		public string content;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6588;
			}
		}

		public GuildMotdSetRequestMessage()
		{
		}

		public GuildMotdSetRequestMessage(string content)
		{
			this.content = content;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.content = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.content);
		}
	}
}