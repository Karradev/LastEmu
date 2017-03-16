using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class InventoryContentAndPresetMessage : InventoryContentMessage
	{
		public const uint Id = 6162;

		public Preset[] presets;

		public IdolsPreset[] idolsPresets;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6162;
			}
		}

		public InventoryContentAndPresetMessage()
		{
		}

		public InventoryContentAndPresetMessage(ObjectItem[] objects, uint kamas, Preset[] presets, IdolsPreset[] idolsPresets) : base(objects, kamas)
		{
			this.presets = presets;
			this.idolsPresets = idolsPresets;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.presets = new Preset[num];
			for (int i = 0; i < num; i++)
			{
				this.presets[i] = new Preset();
				this.presets[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.idolsPresets = new IdolsPreset[num];
			for (int j = 0; j < num; j++)
			{
				this.idolsPresets[j] = new IdolsPreset();
				this.idolsPresets[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.presets.Length));
			Preset[] presetArray = this.presets;
			for (int i = 0; i < (int)presetArray.Length; i++)
			{
				presetArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.idolsPresets.Length));
			IdolsPreset[] idolsPresetArray = this.idolsPresets;
			for (int j = 0; j < (int)idolsPresetArray.Length; j++)
			{
				idolsPresetArray[j].Serialize(writer);
			}
		}
	}
}