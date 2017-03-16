using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismSetSabotagedRequestMessage : NetworkMessage
	{
		public const uint Id = 6468;

		public uint subAreaId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6468;
			}
		}

		public PrismSetSabotagedRequestMessage()
		{
		}

		public PrismSetSabotagedRequestMessage(uint subAreaId)
		{
			this.subAreaId = subAreaId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
		}
	}
}