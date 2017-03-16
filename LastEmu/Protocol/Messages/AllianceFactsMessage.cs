using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AllianceFactsMessage : NetworkMessage
	{
		public const uint Id = 6414;

		public AllianceFactSheetInformations infos;

		public GuildInAllianceInformations[] guilds;

		public uint[] controlledSubareaIds;

		public double leaderCharacterId;

		public string leaderCharacterName;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6414;
			}
		}

		public AllianceFactsMessage()
		{
		}

		public AllianceFactsMessage(AllianceFactSheetInformations infos, GuildInAllianceInformations[] guilds, uint[] controlledSubareaIds, double leaderCharacterId, string leaderCharacterName)
		{
			this.infos = infos;
			this.guilds = guilds;
			this.controlledSubareaIds = controlledSubareaIds;
			this.leaderCharacterId = leaderCharacterId;
			this.leaderCharacterName = leaderCharacterName;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.infos = ProtocolTypeManager.GetInstance<AllianceFactSheetInformations>(reader.ReadUShort());
			this.infos.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.guilds = new GuildInAllianceInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.guilds[i] = new GuildInAllianceInformations();
				this.guilds[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.controlledSubareaIds = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.controlledSubareaIds[j] = reader.ReadVarUhShort();
			}
			this.leaderCharacterId = reader.ReadVarUhLong();
			this.leaderCharacterName = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.infos.TypeId);
			this.infos.Serialize(writer);
			writer.WriteShort((short)((int)this.guilds.Length));
			GuildInAllianceInformations[] guildInAllianceInformationsArray = this.guilds;
			for (int i = 0; i < (int)guildInAllianceInformationsArray.Length; i++)
			{
				guildInAllianceInformationsArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.controlledSubareaIds.Length));
			uint[] numArray = this.controlledSubareaIds;
			for (int j = 0; j < (int)numArray.Length; j++)
			{
				writer.WriteVarShort((int)numArray[j]);
			}
			writer.WriteVarLong(this.leaderCharacterId);
			writer.WriteUTF(this.leaderCharacterName);
		}
	}
}