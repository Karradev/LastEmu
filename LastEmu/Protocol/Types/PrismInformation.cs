using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PrismInformation
	{
		public const short Id = 428;

		public sbyte typeId;

		public sbyte state;

		public int nextVulnerabilityDate;

		public int placementDate;

		public uint rewardTokenCount;

		public virtual short TypeId
		{
			get
			{
				return 428;
			}
		}

		public PrismInformation()
		{
		}

		public PrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount)
		{
			this.typeId = typeId;
			this.state = state;
			this.nextVulnerabilityDate = nextVulnerabilityDate;
			this.placementDate = placementDate;
			this.rewardTokenCount = rewardTokenCount;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.typeId = reader.ReadSByte();
			this.state = reader.ReadSByte();
			this.nextVulnerabilityDate = reader.ReadInt();
			this.placementDate = reader.ReadInt();
			this.rewardTokenCount = reader.ReadVarUhInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.typeId);
			writer.WriteSByte(this.state);
			writer.WriteInt(this.nextVulnerabilityDate);
			writer.WriteInt(this.placementDate);
			writer.WriteVarInt((int)this.rewardTokenCount);
		}
	}
}