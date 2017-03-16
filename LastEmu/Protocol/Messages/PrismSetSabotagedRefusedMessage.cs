using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismSetSabotagedRefusedMessage : NetworkMessage
	{
		public const uint Id = 6466;

		public uint subAreaId;

		public sbyte reason;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6466;
			}
		}

		public PrismSetSabotagedRefusedMessage()
		{
		}

		public PrismSetSabotagedRefusedMessage(uint subAreaId, sbyte reason)
		{
			this.subAreaId = subAreaId;
			this.reason = reason;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
			this.reason = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteSByte(this.reason);
		}
	}
}