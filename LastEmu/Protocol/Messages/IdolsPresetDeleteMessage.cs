using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IdolsPresetDeleteMessage : NetworkMessage
	{
		public const uint Id = 6602;

		public sbyte presetId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6602;
			}
		}

		public IdolsPresetDeleteMessage()
		{
		}

		public IdolsPresetDeleteMessage(sbyte presetId)
		{
			this.presetId = presetId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
		}
	}
}