using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IdolsPresetDeleteResultMessage : NetworkMessage
	{
		public const uint Id = 6605;

		public sbyte presetId;

		public sbyte code;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6605;
			}
		}

		public IdolsPresetDeleteResultMessage()
		{
		}

		public IdolsPresetDeleteResultMessage(sbyte presetId, sbyte code)
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