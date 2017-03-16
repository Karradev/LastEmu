using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IdolsPresetUseMessage : NetworkMessage
	{
		public const uint Id = 6615;

		public sbyte presetId;

		public bool party;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6615;
			}
		}

		public IdolsPresetUseMessage()
		{
		}

		public IdolsPresetUseMessage(sbyte presetId, bool party)
		{
			this.presetId = presetId;
			this.party = party;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
			this.party = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
			writer.WriteBoolean(this.party);
		}
	}
}