using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class AllianceMotdSetRequestMessage : SocialNoticeSetRequestMessage
	{
		public const uint Id = 6687;

		public string content;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6687;
			}
		}

		public AllianceMotdSetRequestMessage()
		{
		}

		public AllianceMotdSetRequestMessage(string content)
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