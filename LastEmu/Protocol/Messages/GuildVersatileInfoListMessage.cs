using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildVersatileInfoListMessage : NetworkMessage
	{
		public const uint Id = 6435;

		public GuildVersatileInformations[] guilds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6435;
			}
		}

		public GuildVersatileInfoListMessage()
		{
		}

		public GuildVersatileInfoListMessage(GuildVersatileInformations[] guilds)
		{
			this.guilds = guilds;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.guilds = new GuildVersatileInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.guilds[i] = ProtocolTypeManager.GetInstance<GuildVersatileInformations>(reader.ReadUShort());
				this.guilds[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.guilds.Length));
			GuildVersatileInformations[] guildVersatileInformationsArray = this.guilds;
			for (int i = 0; i < (int)guildVersatileInformationsArray.Length; i++)
			{
				GuildVersatileInformations guildVersatileInformation = guildVersatileInformationsArray[i];
				writer.WriteShort(guildVersatileInformation.TypeId);
				guildVersatileInformation.Serialize(writer);
			}
		}
	}
}