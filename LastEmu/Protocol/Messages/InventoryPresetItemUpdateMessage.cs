using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class InventoryPresetItemUpdateMessage : NetworkMessage
	{
		public const uint Id = 6168;

		public sbyte presetId;

		public PresetItem presetItem;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6168;
			}
		}

		public InventoryPresetItemUpdateMessage()
		{
		}

		public InventoryPresetItemUpdateMessage(sbyte presetId, PresetItem presetItem)
		{
			this.presetId = presetId;
			this.presetItem = presetItem;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
			this.presetItem = new PresetItem();
			this.presetItem.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
			this.presetItem.Serialize(writer);
		}
	}
}