using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildFactsMessage : NetworkMessage
	{
		public const uint Id = 6415;

		public GuildFactSheetInformations infos;

		public int creationDate;

		public uint nbTaxCollectors;

		public CharacterMinimalInformations[] members;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6415;
			}
		}

		public GuildFactsMessage()
		{
		}

		public GuildFactsMessage(GuildFactSheetInformations infos, int creationDate, uint nbTaxCollectors, CharacterMinimalInformations[] members)
		{
			this.infos = infos;
			this.creationDate = creationDate;
			this.nbTaxCollectors = nbTaxCollectors;
			this.members = members;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.infos = ProtocolTypeManager.GetInstance<GuildFactSheetInformations>(reader.ReadUShort());
			this.infos.Deserialize(reader);
			this.creationDate = reader.ReadInt();
			this.nbTaxCollectors = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.members = new CharacterMinimalInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.members[i] = new CharacterMinimalInformations();
				this.members[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.infos.TypeId);
			this.infos.Serialize(writer);
			writer.WriteInt(this.creationDate);
			writer.WriteVarShort((int)this.nbTaxCollectors);
			writer.WriteShort((short)((int)this.members.Length));
			CharacterMinimalInformations[] characterMinimalInformationsArray = this.members;
			for (int i = 0; i < (int)characterMinimalInformationsArray.Length; i++)
			{
				characterMinimalInformationsArray[i].Serialize(writer);
			}
		}
	}
}