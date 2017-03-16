using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IdolsPresetSaveMessage : NetworkMessage
	{
		public const uint Id = 6603;

		public sbyte presetId;

		public sbyte symbolId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6603;
			}
		}

		public IdolsPresetSaveMessage()
		{
		}

		public IdolsPresetSaveMessage(sbyte presetId, sbyte symbolId)
		{
			this.presetId = presetId;
			this.symbolId = symbolId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
			this.symbolId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
			writer.WriteSByte(this.symbolId);
		}
	}
}