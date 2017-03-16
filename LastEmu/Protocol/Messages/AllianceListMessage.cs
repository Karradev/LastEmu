using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AllianceListMessage : NetworkMessage
	{
		public const uint Id = 6408;

		public AllianceFactSheetInformations[] alliances;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6408;
			}
		}

		public AllianceListMessage()
		{
		}

		public AllianceListMessage(AllianceFactSheetInformations[] alliances)
		{
			this.alliances = alliances;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.alliances = new AllianceFactSheetInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.alliances[i] = new AllianceFactSheetInformations();
				this.alliances[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.alliances.Length));
			AllianceFactSheetInformations[] allianceFactSheetInformationsArray = this.alliances;
			for (int i = 0; i < (int)allianceFactSheetInformationsArray.Length; i++)
			{
				allianceFactSheetInformationsArray[i].Serialize(writer);
			}
		}
	}
}