using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MapRunningFightListMessage : NetworkMessage
	{
		public const uint Id = 5743;

		public FightExternalInformations[] fights;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5743;
			}
		}

		public MapRunningFightListMessage()
		{
		}

		public MapRunningFightListMessage(FightExternalInformations[] fights)
		{
			this.fights = fights;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.fights = new FightExternalInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.fights[i] = new FightExternalInformations();
				this.fights[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.fights.Length));
			FightExternalInformations[] fightExternalInformationsArray = this.fights;
			for (int i = 0; i < (int)fightExternalInformationsArray.Length; i++)
			{
				fightExternalInformationsArray[i].Serialize(writer);
			}
		}
	}
}