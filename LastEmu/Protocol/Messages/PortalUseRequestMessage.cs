using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PortalUseRequestMessage : NetworkMessage
	{
		public const uint Id = 6492;

		public uint portalId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6492;
			}
		}

		public PortalUseRequestMessage()
		{
		}

		public PortalUseRequestMessage(uint portalId)
		{
			this.portalId = portalId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.portalId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.portalId);
		}
	}
}