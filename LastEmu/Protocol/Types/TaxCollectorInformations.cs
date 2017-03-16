using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class TaxCollectorInformations
	{
		public const short Id = 167;

		public int uniqueId;

		public uint firtNameId;

		public uint lastNameId;

		public AdditionalTaxCollectorInformations additionalInfos;

		public short worldX;

		public short worldY;

		public uint subAreaId;

		public sbyte state;

		public EntityLook look;

		public TaxCollectorComplementaryInformations[] complements;

		public virtual short TypeId
		{
			get
			{
				return 167;
			}
		}

		public TaxCollectorInformations()
		{
		}

		public TaxCollectorInformations(int uniqueId, uint firtNameId, uint lastNameId, AdditionalTaxCollectorInformations additionalInfos, short worldX, short worldY, uint subAreaId, sbyte state, EntityLook look, TaxCollectorComplementaryInformations[] complements)
		{
			this.uniqueId = uniqueId;
			this.firtNameId = firtNameId;
			this.lastNameId = lastNameId;
			this.additionalInfos = additionalInfos;
			this.worldX = worldX;
			this.worldY = worldY;
			this.subAreaId = subAreaId;
			this.state = state;
			this.look = look;
			this.complements = complements;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.uniqueId = reader.ReadInt();
			this.firtNameId = reader.ReadVarUhShort();
			this.lastNameId = reader.ReadVarUhShort();
			this.additionalInfos = new AdditionalTaxCollectorInformations();
			this.additionalInfos.Deserialize(reader);
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.subAreaId = reader.ReadVarUhShort();
			this.state = reader.ReadSByte();
			this.look = new EntityLook();
			this.look.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.complements = new TaxCollectorComplementaryInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.complements[i] = ProtocolTypeManager.GetInstance<TaxCollectorComplementaryInformations>(reader.ReadUShort());
				this.complements[i].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.uniqueId);
			writer.WriteVarShort((int)this.firtNameId);
			writer.WriteVarShort((int)this.lastNameId);
			this.additionalInfos.Serialize(writer);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteSByte(this.state);
			this.look.Serialize(writer);
			writer.WriteShort((short)((int)this.complements.Length));
			TaxCollectorComplementaryInformations[] taxCollectorComplementaryInformationsArray = this.complements;
			for (int i = 0; i < (int)taxCollectorComplementaryInformationsArray.Length; i++)
			{
				TaxCollectorComplementaryInformations taxCollectorComplementaryInformation = taxCollectorComplementaryInformationsArray[i];
				writer.WriteShort(taxCollectorComplementaryInformation.TypeId);
				taxCollectorComplementaryInformation.Serialize(writer);
			}
		}
	}
}