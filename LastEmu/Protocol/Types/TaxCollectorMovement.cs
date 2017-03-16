using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TaxCollectorMovement
	{
		public const short Id = 493;

		public sbyte movementType;

		public TaxCollectorBasicInformations basicInfos;

		public double playerId;

		public string playerName;

		public virtual short TypeId
		{
			get
			{
				return 493;
			}
		}

		public TaxCollectorMovement()
		{
		}

		public TaxCollectorMovement(sbyte movementType, TaxCollectorBasicInformations basicInfos, double playerId, string playerName)
		{
			this.movementType = movementType;
			this.basicInfos = basicInfos;
			this.playerId = playerId;
			this.playerName = playerName;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.movementType = reader.ReadSByte();
			this.basicInfos = new TaxCollectorBasicInformations();
			this.basicInfos.Deserialize(reader);
			this.playerId = reader.ReadVarUhLong();
			this.playerName = reader.ReadUTF();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.movementType);
			this.basicInfos.Serialize(writer);
			writer.WriteVarLong(this.playerId);
			writer.WriteUTF(this.playerName);
		}
	}
}