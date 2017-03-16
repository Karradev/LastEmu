using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PortalInformation
	{
		public const short Id = 466;

		public int portalId;

		public short areaId;

		public virtual short TypeId
		{
			get
			{
				return 466;
			}
		}

		public PortalInformation()
		{
		}

		public PortalInformation(int portalId, short areaId)
		{
			this.portalId = portalId;
			this.areaId = areaId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.portalId = reader.ReadInt();
			this.areaId = reader.ReadShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.portalId);
			writer.WriteShort(this.areaId);
		}
	}
}