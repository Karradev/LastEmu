using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AllianceInsiderInfoMessage : NetworkMessage
	{
		public const uint Id = 6403;

		public AllianceFactSheetInformations allianceInfos;

		public GuildInsiderFactSheetInformations[] guilds;

		public PrismSubareaEmptyInfo[] prisms;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6403;
			}
		}

		public AllianceInsiderInfoMessage()
		{
		}

		public AllianceInsiderInfoMessage(AllianceFactSheetInformations allianceInfos, GuildInsiderFactSheetInformations[] guilds, PrismSubareaEmptyInfo[] prisms)
		{
			this.allianceInfos = allianceInfos;
			this.guilds = guilds;
			this.prisms = prisms;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.allianceInfos = new AllianceFactSheetInformations();
			this.allianceInfos.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.guilds = new GuildInsiderFactSheetInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.guilds[i] = new GuildInsiderFactSheetInformations();
				this.guilds[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.prisms = new PrismSubareaEmptyInfo[num];
			for (int j = 0; j < num; j++)
			{
				this.prisms[j] = ProtocolTypeManager.GetInstance<PrismSubareaEmptyInfo>(reader.ReadUShort());
				this.prisms[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			this.allianceInfos.Serialize(writer);
			writer.WriteShort((short)((int)this.guilds.Length));
			GuildInsiderFactSheetInformations[] guildInsiderFactSheetInformationsArray = this.guilds;
			for (int i = 0; i < (int)guildInsiderFactSheetInformationsArray.Length; i++)
			{
				guildInsiderFactSheetInformationsArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.prisms.Length));
			PrismSubareaEmptyInfo[] prismSubareaEmptyInfoArray = this.prisms;
			for (int j = 0; j < (int)prismSubareaEmptyInfoArray.Length; j++)
			{
				PrismSubareaEmptyInfo prismSubareaEmptyInfo = prismSubareaEmptyInfoArray[j];
				writer.WriteShort(prismSubareaEmptyInfo.TypeId);
				prismSubareaEmptyInfo.Serialize(writer);
			}
		}
	}
}