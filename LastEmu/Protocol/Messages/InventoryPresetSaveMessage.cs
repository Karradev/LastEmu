using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class InventoryPresetSaveMessage : NetworkMessage
	{
		public const uint Id = 6165;

		public sbyte presetId;

		public sbyte symbolId;

		public bool saveEquipment;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6165;
			}
		}

		public InventoryPresetSaveMessage()
		{
		}

		public InventoryPresetSaveMessage(sbyte presetId, sbyte symbolId, bool saveEquipment)
		{
			this.presetId = presetId;
			this.symbolId = symbolId;
			this.saveEquipment = saveEquipment;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
			this.symbolId = reader.ReadSByte();
			this.saveEquipment = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
			writer.WriteSByte(this.symbolId);
			writer.WriteBoolean(this.saveEquipment);
		}
	}
}