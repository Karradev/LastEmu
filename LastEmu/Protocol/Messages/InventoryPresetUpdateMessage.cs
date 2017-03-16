using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class InventoryPresetUpdateMessage : NetworkMessage
	{
		public const uint Id = 6171;

		public Preset preset;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6171;
			}
		}

		public InventoryPresetUpdateMessage()
		{
		}

		public InventoryPresetUpdateMessage(Preset preset)
		{
			this.preset = preset;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.preset = new Preset();
			this.preset.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.preset.Serialize(writer);
		}
	}
}