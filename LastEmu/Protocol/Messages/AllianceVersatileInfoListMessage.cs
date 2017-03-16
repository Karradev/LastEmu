using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AllianceVersatileInfoListMessage : NetworkMessage
	{
		public const uint Id = 6436;

		public AllianceVersatileInformations[] alliances;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6436;
			}
		}

		public AllianceVersatileInfoListMessage()
		{
		}

		public AllianceVersatileInfoListMessage(AllianceVersatileInformations[] alliances)
		{
			this.alliances = alliances;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.alliances = new AllianceVersatileInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.alliances[i] = new AllianceVersatileInformations();
				this.alliances[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.alliances.Length));
			AllianceVersatileInformations[] allianceVersatileInformationsArray = this.alliances;
			for (int i = 0; i < (int)allianceVersatileInformationsArray.Length; i++)
			{
				allianceVersatileInformationsArray[i].Serialize(writer);
			}
		}
	}
}