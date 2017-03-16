using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class AllianceBulletinSetRequestMessage : SocialNoticeSetRequestMessage
	{
		public const uint Id = 6693;

		public string content;

		public bool notifyMembers;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6693;
			}
		}

		public AllianceBulletinSetRequestMessage()
		{
		}

		public AllianceBulletinSetRequestMessage(string content, bool notifyMembers)
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