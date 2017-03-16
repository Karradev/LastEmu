using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class InventoryPresetSaveResultMessage : NetworkMessage
	{
		public const uint Id = 6170;

		public sbyte presetId;

		public sbyte code;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6170;
			}
		}

		public InventoryPresetSaveResultMessage()
		{
		}

		public InventoryPresetSaveResultMessage(sbyte presetId, sbyte code)
		{
			this.presetId = presetId;
			this.code = code;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
			this.code = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
			writer.WriteSByte(this.code);
		}
	}
}