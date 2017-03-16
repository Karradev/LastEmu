using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildInformationsPaddocksMessage : NetworkMessage
	{
		public const uint Id = 5959;

		public sbyte nbPaddockMax;

		public PaddockContentInformations[] paddocksInformations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5959;
			}
		}

		public GuildInformationsPaddocksMessage()
		{
		}

		public GuildInformationsPaddocksMessage(sbyte nbPaddockMax, PaddockContentInformations[] paddocksInformations)
		{
			this.nbPaddockMax = nbPaddockMax;
			this.paddocksInformations = paddocksInformations;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.nbPaddockMax = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.paddocksInformations = new PaddockContentInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.paddocksInformations[i] = new PaddockContentInformations();
				this.paddocksInformations[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.nbPaddockMax);
			writer.WriteShort((short)((int)this.paddocksInformations.Length));
			PaddockContentInformations[] paddockContentInformationsArray = this.paddocksInformations;
			for (int i = 0; i < (int)paddockContentInformationsArray.Length; i++)
			{
				paddockContentInformationsArray[i].Serialize(writer);
			}
		}
	}
}