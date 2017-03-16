using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismSettingsRequestMessage : NetworkMessage
	{
		public const uint Id = 6437;

		public uint subAreaId;

		public sbyte startDefenseTime;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6437;
			}
		}

		public PrismSettingsRequestMessage()
		{
		}

		public PrismSettingsRequestMessage(uint subAreaId, sbyte startDefenseTime)
		{
			this.subAreaId = subAreaId;
			this.startDefenseTime = startDefenseTime;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
			this.startDefenseTime = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteSByte(this.startDefenseTime);
		}
	}
}