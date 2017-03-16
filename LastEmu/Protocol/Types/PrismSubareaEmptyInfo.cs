using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PrismSubareaEmptyInfo
	{
		public const short Id = 438;

		public uint subAreaId;

		public uint allianceId;

		public virtual short TypeId
		{
			get
			{
				return 438;
			}
		}

		public PrismSubareaEmptyInfo()
		{
		}

		public PrismSubareaEmptyInfo(uint subAreaId, uint allianceId)
		{
			this.subAreaId = subAreaId;
			this.allianceId = allianceId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
			this.allianceId = reader.ReadVarUhInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteVarInt((int)this.allianceId);
		}
	}
}