using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildInformationsMembersMessage : NetworkMessage
	{
		public const uint Id = 5558;

		public GuildMember[] members;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5558;
			}
		}

		public GuildInformationsMembersMessage()
		{
		}

		public GuildInformationsMembersMessage(GuildMember[] members)
		{
			this.members = members;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.members = new GuildMember[num];
			for (int i = 0; i < num; i++)
			{
				this.members[i] = new GuildMember();
				this.members[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.members.Length));
			GuildMember[] guildMemberArray = this.members;
			for (int i = 0; i < (int)guildMemberArray.Length; i++)
			{
				guildMemberArray[i].Serialize(writer);
			}
		}
	}
}