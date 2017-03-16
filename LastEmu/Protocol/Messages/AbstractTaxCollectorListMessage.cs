using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AbstractTaxCollectorListMessage : NetworkMessage
	{
		public const uint Id = 6568;

		public TaxCollectorInformations[] informations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6568;
			}
		}

		public AbstractTaxCollectorListMessage()
		{
		}

		public AbstractTaxCollectorListMessage(TaxCollectorInformations[] informations)
		{
			this.informations = informations;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.informations = new TaxCollectorInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.informations[i] = ProtocolTypeManager.GetInstance<TaxCollectorInformations>(reader.ReadUShort());
				this.informations[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.informations.Length));
			TaxCollectorInformations[] taxCollectorInformationsArray = this.informations;
			for (int i = 0; i < (int)taxCollectorInformationsArray.Length; i++)
			{
				TaxCollectorInformations taxCollectorInformation = taxCollectorInformationsArray[i];
				writer.WriteShort(taxCollectorInformation.TypeId);
				taxCollectorInformation.Serialize(writer);
			}
		}
	}
}