using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class TaxCollectorListMessage : AbstractTaxCollectorListMessage
	{
		public const uint Id = 5930;

		public sbyte nbcollectorMax;

		public TaxCollectorFightersInformation[] fightersInformations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5930;
			}
		}

		public TaxCollectorListMessage()
		{
		}

		public TaxCollectorListMessage(TaxCollectorInformations[] informations, sbyte nbcollectorMax, TaxCollectorFightersInformation[] fightersInformations) : base(informations)
		{
			this.nbcollectorMax = nbcollectorMax;
			this.fightersInformations = fightersInformations;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.nbcollectorMax = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.fightersInformations = new TaxCollectorFightersInformation[num];
			for (int i = 0; i < num; i++)
			{
				this.fightersInformations[i] = new TaxCollectorFightersInformation();
				this.fightersInformations[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.nbcollectorMax);
			writer.WriteShort((short)((int)this.fightersInformations.Length));
			TaxCollectorFightersInformation[] taxCollectorFightersInformationArray = this.fightersInformations;
			for (int i = 0; i < (int)taxCollectorFightersInformationArray.Length; i++)
			{
				taxCollectorFightersInformationArray[i].Serialize(writer);
			}
		}
	}
}