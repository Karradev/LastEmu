using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class IdolsPresetUpdateMessage : NetworkMessage
	{
		public const uint Id = 6606;

		public IdolsPreset idolsPreset;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6606;
			}
		}

		public IdolsPresetUpdateMessage()
		{
		}

		public IdolsPresetUpdateMessage(IdolsPreset idolsPreset)
		{
			this.idolsPreset = idolsPreset;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.idolsPreset = new IdolsPreset();
			this.idolsPreset.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.idolsPreset.Serialize(writer);
		}
	}
}