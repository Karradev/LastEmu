using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PrismsInfoValidMessage : NetworkMessage
	{
		public const uint Id = 6451;

		public PrismFightersInformation[] fights;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6451;
			}
		}

		public PrismsInfoValidMessage()
		{
		}

		public PrismsInfoValidMessage(PrismFightersInformation[] fights)
		{
			this.fights = fights;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.fights = new PrismFightersInformation[num];
			for (int i = 0; i < num; i++)
			{
				this.fights[i] = new PrismFightersInformation();
				this.fights[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.fights.Length));
			PrismFightersInformation[] prismFightersInformationArray = this.fights;
			for (int i = 0; i < (int)prismFightersInformationArray.Length; i++)
			{
				prismFightersInformationArray[i].Serialize(writer);
			}
		}
	}
}